using DesignPatterns.Creational.Singleton;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatterns.Controllers
{
    public class SingletonController : Controller
    {
        public string Index()
        {
            var strRetorno = new StringBuilder();
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                strRetorno.AppendLine("Mesma instância");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (var i = 0; i < 15; i++)
            {
                var nextServer = balancer.NextServer;
                strRetorno.AppendLine($"Disparando request para: { nextServer.Nome} - {nextServer.Id}");
            }
            return strRetorno.ToString();
        }
    }
}
