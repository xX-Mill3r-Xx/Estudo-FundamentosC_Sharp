using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    class Divisao
    {
        public float V1 { get; set; }
        public float V2 { get; set; }

        public Divisao()
        {
        }

        public Divisao(float v1, float v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public float DivideValues(float v1, float v2)
        {
            float result = v1 / v2;
            return result;
        }

        public override string ToString()
        {
            return $"O resuldado da divisão destes valores é {DivideValues(V1, V2).ToString("F1", CultureInfo.InvariantCulture)}";
        }
    }
}
