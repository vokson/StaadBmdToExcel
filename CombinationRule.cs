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
        abstract public float combine(float[] values, double[] frequencies );
    }

    // SRSS
    class SRSSCombinationRule : CombinationRule
    {
        public SRSSCombinationRule(string name, double multiplicator) :
            base(name, multiplicator) { }

        public override float combine (float[] values, double[] frequencies = null)
        {
            double result = 0.0;

            for (int i=0; i < values.Length; i++)
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
            base(name, multiplicator) { }

        public override float combine(float[] values, double[] frequencies = null)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            for (int i = 0; i < values.Length-1; i++)
                for (int j = i+1; j < values.Length; j++)
                {
                result += 0.6*values[i]*values[j];
            }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }
    }

    // KMK 2.01.03 formula 2.8 with modulus (LIRA way)
    class UZModulusCombinationRule : CombinationRule
    {
        public UZModulusCombinationRule(string name, double multiplicator) :
            base(name, multiplicator) { }

        public override float combine(float[] values, double[] frequencies = null)
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
            base(name, multiplicator, modalDamping) { }

        public override float combine(float[] values, double[] frequencies)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++) {
                for (int j = 0; j < values.Length; j++)
                {
                    // Betta
                    double betta = frequencies[j] / frequencies[i];
                    // Rij
                    double Rij = 1;
                    Rij *= 8 * Math.Pow(damp, 2) * (1 + betta) * Math.Pow(betta, 1.5);
                    Rij *= 1 / (Math.Pow(1-Math.Pow(betta,2),2)+4*Math.Pow(damp,2)*betta*Math.Pow(1+betta,2));
                    // Sum
                    result += values[i] * values[j] * Rij;
                }
            }

            result = Math.Sqrt(result) * multiplicator;

            return (float)result;
        }
    }
}
