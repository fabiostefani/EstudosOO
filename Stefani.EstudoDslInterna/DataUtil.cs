using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefani.EstudoDslInterna
{
    public static class DataUtil
    {
        public const int UM_DIA = 1;
        public const int DOIS_DIAS = 2;
        public const int TRES_DIAS = 3;
        public const int QUATRO_DIAS = 4;

        public static DateTime DaquiA(int numDias)
        {
            return DateTime.Now.AddDays(numDias).Date;
        }
    }
}
