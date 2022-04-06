using System;
using System.Globalization;

namespace Operacoes
{
    class Multiplicacao
    {
        public float V1 { get; set; }
        public float V2 { get; set; }

        public Multiplicacao()
        {
        }

        public Multiplicacao(float v1, float v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public float MultiplyValues(float v1, float v2)
        {
            float result = v1 * v2;
            return result;
        }

        public override string ToString()
        {
            return $"O resuldado da multiplicação destes valores é {MultiplyValues(V1, V2).ToString("F1", CultureInfo.InvariantCulture)}";
        }
    }
}
