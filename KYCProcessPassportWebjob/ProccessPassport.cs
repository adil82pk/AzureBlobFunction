using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using KYCProcessPassportWebjob.AbbyyCloudOCR;
using KYCProcessPassportWebjob.Trulioo;
using Transaction = KYCProcessPassportWebjob.Trulioo.Transaction;

namespace KYCProcessPassportWebjob
{
    /// <summary>
    /// Azure blob function to read each uploaded image from the stream
    /// </summary>
    public static class ProccessPassport
    {
        /// <summary>
        /// Passport Image Blob Function
        /// </summary>
        /// <param name="blob">image as stream</param>
        /// <param name="name">name of the image</param>
        /// <param name="log">object of TraceWriter</param>
        [FunctionName("ProccessPassport")]
        public async static void Run([BlobTrigger("kyccontainer/{name}", Connection = "AzureWebJobsStorage")]Stream blob, string name, TraceWriter log)
        {
            try
            {
                log.Info($"Azure blob function triggered for the passport image: {name}");

                // Resolve assembly
                FunctionsAssemblyResolver.StaticInstance();

                // Using AbbyyCloudOCR to extract Passport details
                RestServiceClient restClient = new RestServiceClient();

                // Convert stream into image stream
                MemoryStream streamOut = ImageStream.GetImageStream(blob);
                OcrSdkTask task = restClient.ProcessMrz(streamOut);

                // Get Passport details
                AbbyyCloudOCRResponse abbyyCloudOCRResponse = restClient.WaitAndGetAbbyyCloudOCRResponse(task);

                // Using Trulioo API for Passport verification
                Transaction transaction = await Verify.VerifyPassport(abbyyCloudOCRResponse, streamOut);

                // Save the AbbyyCloudOCR response and transaction response into the database
                DataLayer.KYCDbContext.Save(abbyyCloudOCRResponse, transaction);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex, "KYC blob function");
            }
        }
    }
}
