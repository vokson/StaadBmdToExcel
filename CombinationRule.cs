using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMDtoExcel
{
    abstract class CombinationRule
    {
        public string name = "Empty"; /* Name of rule */
        public double multiplicator = 1.0; /* Multiplicator for result */
        public double damp = 0.03; /* Modal damping ration */

        // Default constructor
        public CombinationRule(string name, double multiplicator = 1.0, double modalDamping = 0.03)
        {
            this.name = name;
            this.multiplicator = multiplicator;
            this.damp = modalDamping;
        }

        /*
         * values - array of values to be combined
         * frequencies - array of frequencies
        */
        abstract public double combine(float[] values, double[] frequencies);
    }

    // SRSS
    class SRSSCombinationRule : CombinationRule
    {
        public SRSSCombinationRule(string name, double multiplicator) :
            base(name, multiplicator)
        { }

        public override double combine(float[] values, double[] frequencies = null)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }


    }


    // KMK 2.01.03 formula 2.8
    class UZCombinationRule : CombinationRule
    {
        public UZCombinationRule(string name, double multiplicator) :
            base(name, multiplicator)
        { }

        public override double combine(float[] values, double[] frequencies = null)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            for (int i = 0; i < values.Length - 1; i++)
                for (int j = i + 1; j < values.Length; j++)
                {
                    result += 0.6 * values[i] * values[j];
                }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }
    }

    // KMK 2.01.03 formula 2.8 with modulus (LIRA way)
    class UZModulusCombinationRule : CombinationRule
    {
        public UZModulusCombinationRule(string name, double multiplicator) :
            base(name, multiplicator)
        { }

        public override double combine(float[] values, double[] frequencies = null)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            for (int i = 0; i < values.Length - 1; i++)
                for (int j = i + 1; j < values.Length; j++)
                {
                    result += Math.Abs(0.6 * values[i] * values[j]);
                }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }
    }




    // CQC
    class CQCCombinationRule : CombinationRule
    {
        public CQCCombinationRule(string name, double multiplicator, double modalDamping) :
            base(name, multiplicator, modalDamping)
        { }


        public override double combine(float[] values, double[] frequencies)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    double Rij = Math.Min(cqcRij(frequencies[i], frequencies[j], this.damp),
                        cqcRij(frequencies[j], frequencies[i], this.damp));
                    // Rij <= 1
                    if (Rij > 1) { Rij = 1; }

                    //double Rij = Math.Min(cqcRij(frequencies[i], frequencies[j], this.damp, this.damp),
                    //    cqcRij(frequencies[j], frequencies[i], this.damp, this.damp));

                    // Sum
                    result += values[i] * values[j] * Rij;
                }
            }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }

        // Factor Rij for CQC
        private double cqcRij(double f1, double f2, double damp)
        {
            // Betta
            double betta = f1 / f2;
            // Rij
            double Rij = 1;
            Rij *= 8 * Math.Pow(damp, 2) * (1 + betta) * Math.Pow(betta, 1.5);
            Rij *= 1 / (Math.Pow(1 - Math.Pow(betta, 2), 2) + 4 * Math.Pow(damp, 2) * betta * Math.Pow(1 + betta, 2));

            return Rij;
        }

        // Factor Rij for CQC (formula for different modal damping for frequencies)
        private double cqcRij(double fi, double fj, double damp1, double damp2)
        {
            // Betta
            double betta = fi / fj;
            // Rij
            double Rij = 1;
            Rij *= 8 * Math.Sqrt(damp1 * damp2) * (damp1 + betta * damp2) * Math.Pow(betta, 1.5);
            Rij *= 1 / (1 - Math.Pow(betta, 2) + 4 * damp1 * damp2 * (1 + Math.Pow(betta, 2)) + 4 * Math.Pow(betta, 2) * (Math.Pow(damp1, 2) + Math.Pow(damp2, 2)));


            return Rij;
        }


    }


    // ASCE
    class ASCECombinationRule : CombinationRule
    {
        public double ff1 = 0;  /* f1 frequency described in ASCE4-98 cl.3.2.7.1.1. Defaul 2Hz */
        public double ff2 = 0; /* f2 frequency described in ASCE4-98 cl.3.2.7.1.1. Defaul 33Hz */

        public ASCECombinationRule(string name, double multiplicator, double modalDamping,
            double ff1 = 2, double ff2 = 33) : base(name, multiplicator, modalDamping)
        {
            this.ff1 = ff1;
            this.ff2 = ff2;
        }


        public override double combine(float[] values, double[] frequencies)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    result += values[i] * values[j]
                        * Eij(frequencies[i], frequencies[j], this.damp, this.damp);
                }
            }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }

        // Calculate alpha coefficient for frequency f
        private double alpha(double f)
        {
            double result = Math.Log(f / this.ff1) / Math.Log(ff2 / ff1);

            // 0 <= result <= 1
            if (result < 0) { result = 0; }
            if (result > 1) { result = 1; }

            return result;
        }

        // Calculate _Eij
        // fi, fj - frequeincies
        // dj, dj - modal dampings
        private double _Eij(double fi, double fj, double di, double dj)
        {
            double result = 2 * Math.Sqrt(di * dj) / (di + dj);
            result *= Math.Pow(1 + Math.Pow((fi - fj) / (di * fi + dj * fj), 2), -1);

            return result;
        }

        // Calculate Eij
        // fi, fj - frequeincies
        // dj, dj - modal dampings
        private double Eij(double fi, double fj, double di, double dj)
        {
            double Ai = alpha(fi);
            double Aj = alpha(fj);

            double result = Math.Sqrt((1 - Math.Pow(Ai, 2)) * (1 - Math.Pow(Aj, 2)));

            result *= _Eij(fi, fj, di, dj);

            result += Ai * Aj;

            return result;
        }
    }
}
