using KYCProcessPassportWebjob.AbbyyCloudOCR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYCProcessPassportWebjob.Trulioo
{
    public static class Verify
    {
        private static string ConfigurationName = "Document Verification";
        private static string DocumentType = "Passport";

        public async static Task<Transaction> VerifyPassport(AbbyyCloudOCRResponse abbyyCloudOCRResponse, MemoryStream streamOut)
        {
            // Using Trulioo to verify extracted passport details
            TruliooClient truliooClient = new TruliooClient();
            VerifyRequest requestValidate = new VerifyRequest()
            {
                AcceptTruliooTermsAndConditions = true,
                CleansedAddress = false,
                CallBackUrl =  Environment.GetEnvironmentVariable("CallBackURL"),
                ConfigurationName = ConfigurationName,
                CountryCode = CountryCodes.Mapping[abbyyCloudOCRResponse.IssuingCountry],
                VerboseMode = true,
                DataFields = new DataFields()
                {
                    PersonInfo = new PersonInfo()
                    {
                        FirstGivenName = abbyyCloudOCRResponse.GivenName,
                        FirstSurName = abbyyCloudOCRResponse.LastName,
                    },
                    Document = new Document() { AcceptIncompleteDocument = true, DocumentType = DocumentType, DocumentBackImage = streamOut.ToArray(), LivePhoto = null, ValidateDocumentImageQuality = true, DocumentFrontImage = streamOut.ToArray() },
                }
            };
            return await truliooClient.Verify(requestValidate);
        }
    }
}
