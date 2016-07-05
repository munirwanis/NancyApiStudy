using Nancy.Hosting.Self;
using System;

namespace NancyApiStudy.SelfHost {
    class Program {
        static void Main(string[] args) {
            var uri = new Uri("http://localhost:1234");
            Console.WriteLine("If it doesn't work run the following command with root privileges");
            Console.WriteLine($"netsh http add urlacl url={uri.ToString().Replace("localhost", "+")} user=Everyone");
            try {
                HostConfiguration config = new HostConfiguration {
                    RewriteLocalhost = true,
                    UrlReservations = new UrlReservations {
                        CreateAutomatically = true,
                        User = "Everyone"
                    }
                };
                var host = new NancyHost(uri);
                host.Start();
                Console.WriteLine($"Running on {uri.ToString()}");
                Console.ReadKey();
                host.Stop();
            }
            catch (Exception ex) {
                throw ex;
            }
            //using (var host = new NancyHost(new Uri("http://localhost:1234"))) {
            //    Console.WriteLine($"Running on {uri.ToString()}");
            //    Console.ReadKey();
            //}
        }
    }
}
