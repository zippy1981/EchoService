using System;
using System.ServiceModel;

namespace EchoService
{
    public static class Program
    {
        public static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(EchoService)))
            {
                host.Open();
                Console.WriteLine("Press Any Key to Continue . . .");
                Console.ReadKey(true);
                host.Close();
            }
        }
    }
}