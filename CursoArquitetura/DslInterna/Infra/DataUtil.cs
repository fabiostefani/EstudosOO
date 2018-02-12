using System;

namespace DslInterna.Infra
{
    public class DataUtil
    {
        public const int UM_DIA = 1;
        public const int DOIS_DIAS = 2;
        public const int TRES_DIAS = 3;
        public const int QUATRO_DIAS = 4;

        public static DateTime DaquiA(int diasSomar)
        {
            return DateTime.Now.AddDays(diasSomar).Date;
        }
    }
}
