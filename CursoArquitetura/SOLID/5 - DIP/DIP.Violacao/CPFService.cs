namespace SOLID._5___DIP.DIP.Violacao
{
    public static class CPFService
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
