using System.Net;

namespace SimpleDNS
{
    public class SimpleDNS
    {
        public static DNS.Server.DnsServer Server;

        public static void Main(string[] args)
        {
            Server = new DNS.Server.DnsServer(new Resolver());
            Server.Listen(new IPEndPoint(IPAddress.IPv6Any, 53)).Wait();
        }
    }
}
