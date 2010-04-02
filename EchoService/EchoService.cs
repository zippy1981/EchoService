using System.ServiceModel;

namespace EchoService
{
/*
 * This script is used to test PHP bug 50698.
 * http://bugs.php.net/bug.php?id=50698
 */
	
    /// <summary>Simple test service.</summary>
    [ServiceContract]
    public sealed class EchoService
    {
    	/// <summary>Echo operation.</summary>
    	/// <param name="request"></param>
    	/// <returns></returns>
        [OperationContract]
        public string Echo(string request)
        {
            return request;
        }
    }
}
