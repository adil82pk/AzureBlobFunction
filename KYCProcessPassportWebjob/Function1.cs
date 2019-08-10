using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace KYCProcessPassportWebjob
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([BlobTrigger("kyccontainer/{name}", Connection = "DefaultEndpointsProtocol=https;AccountName=kycstorage;AccountKey=txbeZLRldWh31kQt4XQBF+eZGITcedseHTTAz39DzdO63wZE103/cl0YRolQME3xcNR2wmtqnJCViqZVYjhhmw==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
