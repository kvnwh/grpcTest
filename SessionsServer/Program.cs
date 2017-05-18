using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace SessionsServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int Port = 50051;
            Server server = new Server
            {
                Services = {Sessions.Sessions.BindService(new SessionsServerImpl())},
                Ports = {new ServerPort("localhost", Port, ServerCredentials.Insecure)}
            };

            server.Start();
            Console.WriteLine("RouteGuide server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}