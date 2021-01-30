using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instace = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server() {Id = Guid.NewGuid(), Nome = "ServerI", IP = "192.168.0.1"},
                new Server() { Id = Guid.NewGuid(), Nome = "ServerII", IP = "192.168.0.2" },
                new Server() { Id = Guid.NewGuid(), Nome = "ServerIII", IP = "192.168.0.3" },
                new Server() { Id = Guid.NewGuid(), Nome = "ServerIV", IP = "192.168.0.4" },
                new Server() { Id = Guid.NewGuid(), Nome = "ServerV", IP = "192.168.0.5" }
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instace;
        }

        public Server NextServer
        {
            get
            {
                var ra = _random.Next(_servers.Count);
                return _servers[ra];
            }
        }
    }
}
