using KYCProcessPassportWebjob.Models;
using System;
using System.Collections.Generic;

namespace KYCProcessPassportWebjob.DataLayer
{
    public static class KYCDbContext
    {
        public static void Save(AbbyyCloudOCR.AbbyyCloudOCRResponse abbyyCloudOCRResponse, Trulioo.Transaction transaction)
        {
            var abbyyCloudOcrresponseId = Guid.NewGuid().ToString();

            // Saving the data to the database using EF
            using (var context = new KYCContext())
            {
                var AbbyyCloudOcrResponseDb = new AbbyyCloudOcrresponse()
                {
                    BirthDate = abbyyCloudOCRResponse.BirthDate,
                    BirthDateCheck = abbyyCloudOCRResponse.BirthDateCheck,
                    BirthDateVerified = abbyyCloudOCRResponse.BirthDateVerified,
                    Checksum = abbyyCloudOCRResponse.Checksum,
                    ChecksumVerified = abbyyCloudOCRResponse.ChecksumVerified,
                    DocumentNumber = abbyyCloudOCRResponse.DocumentNumber,
                    DocumentNumberCheck = abbyyCloudOCRResponse.DocumentNumberCheck,
                    DocumentNumberVerified = abbyyCloudOCRResponse.DocumentNumberVerified,
                    DocumentSubtype = abbyyCloudOCRResponse.DocumentSubtype,
                    DocumentType = abbyyCloudOCRResponse.DocumentType,
                    ExpiryDate = abbyyCloudOCRResponse.ExpiryDate,
                    ExpiryDateCheck = abbyyCloudOCRResponse.ExpiryDateCheck,
                    ExpiryDateVerified = abbyyCloudOCRResponse.ExpiryDateVerified,
                    GivenName = abbyyCloudOCRResponse.GivenName,
                    Id = abbyyCloudOcrresponseId,
                    IssuingCountry = abbyyCloudOCRResponse.IssuingCountry,
                    LastName = abbyyCloudOCRResponse.LastName,
                    MrzType = abbyyCloudOCRResponse.MrzType,
                    Nationality = abbyyCloudOCRResponse.Nationality,
                    PersonalNumber = abbyyCloudOCRResponse.PersonalNumber,
                    PersonalNumberCheck = abbyyCloudOCRResponse.PersonalNumberCheck,
                    PersonalNumberVerified = abbyyCloudOCRResponse.PersonalNumberVerified,
                    Sex = abbyyCloudOCRResponse.Sex,
                    Line1 = abbyyCloudOCRResponse.Line1,
                    Line2 = abbyyCloudOCRResponse.Line2,
                    Transaction = new List<Models.Transaction>() { new Models.Transaction() { AbbyyCloudOcrresponseId = abbyyCloudOcrresponseId, CountryCode = transaction.CountryCode, RecordStatus = transaction.RecordStatus, TransactionId = transaction.TransactionID } }
                };

                context.AbbyyCloudOcrresponse.Add(AbbyyCloudOcrResponseDb);
                context.SaveChanges();
            }
        }
    }
}
