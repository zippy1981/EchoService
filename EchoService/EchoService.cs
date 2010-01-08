using System.ServiceModel;

namespace EchoService
{
    // NOTE: If you change the interface name "EchoService" here, you must also update the reference to "EchoService" in App.config.
    [ServiceContract]
    public sealed class EchoService
    {
        [OperationContract]
        public string Echo(string request)
        {
            return request;
        }
    }
}
