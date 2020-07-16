﻿namespace Arquitetura.OOP
{
    public class AutomacaoCafe
    {
        public static void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.FazerCafe();
            espresso.Desligar();
        }
    }
}
