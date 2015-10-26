using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMDtoExcel
{
    abstract class CombinationRule
    {
        public string name = "Empty";
        abstract public float combine(float[] values);
    }

    class SRSSCombinationRule : CombinationRule
    {
        public SRSSCombinationRule() {
            this.name = "SRSS";
        }

        public override float combine (float[] values)
        {
            double result = 0.0;

            for (int i=0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            result = Math.Sqrt(result);

            return (float)result;
        }
    }

    class multiSRSSCombinationRule : CombinationRule
    {
        public multiSRSSCombinationRule()
        {
            this.name = "1.3_SRSS";
        }

        public override float combine(float[] values)
        {
            double result = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                result += Math.Pow(values[i], 2);
            }

            result = Math.Sqrt(1.3*result);

            return (float)result;
        }
    }

    // KMK 2.01.03 formula 2.8
    class UZCombinationRule : CombinationRule
    {
        public UZCombinationRule()
        {
            this.name = "UZ";
        }

        public override float combine(float[] values)
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

            result = Math.Sqrt(result);

            return (float)result;
        }
    }

    // KMK 2.01.03 formula 2.8 with modulus (LIRA way)
    class UZModulusCombinationRule : CombinationRule
    {
        public UZModulusCombinationRule()
        {
            this.name = "|UZ|";
        }

        public override float combine(float[] values)
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

            result = Math.Sqrt(result);

            return (float)result;
        }
    }
}
