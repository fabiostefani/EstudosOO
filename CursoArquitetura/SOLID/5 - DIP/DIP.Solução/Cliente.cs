﻿using System;

namespace SOLID._5___DIP.DIP.Solução
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return EmailHelper.IsValid(Email) && CPFService.IsValid(Cpf);
        }
    }
}
