namespace DesignPatterns.Behavioral.Strategy.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
