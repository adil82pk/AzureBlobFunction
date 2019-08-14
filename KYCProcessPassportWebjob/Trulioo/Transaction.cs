namespace KYCProcessPassportWebjob.Trulioo
{
    public class Transaction
    {
        public string TransactionID { get; set; }
        public string RecordStatus { get; set; }
        public string CountryCode { get; set; }

        public string AbbyyCloudOCRResponseId { get; set; }
    }
}
