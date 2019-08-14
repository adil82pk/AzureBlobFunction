using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KYCProcessPassportWebjob.Trulioo
{
    public class TruliooClient
    {
        private HttpClient _httpClient;

        private static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            DateFormatHandling = DateFormatHandling.IsoDateFormat
        };

        public async Task<Transaction> Verify(VerifyRequest requestValidate)
        {
            dynamic response;
            Transaction transaction = new Transaction();
            using (var request = new HttpRequestMessage(HttpMethod.Post, "https://gateway.trulioo.com/trial/verifications/v1/verify") { Content = GetStringContent(requestValidate) })
            {
                request.Headers.Add("Authorization", $"Basic bWFrX25lZF9BVF9ob3RtYWlsLmNvbTphZGlsMTIzNEBhMQ==");

                _httpClient = new HttpClient();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient.DefaultRequestHeaders.Add("x-trulioo-api-key", "5f098ea0303b98da1a6905ade986c323");

                response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, CancellationToken.None).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var message = JsonConvert.DeserializeObject<object>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    JObject result = JObject.Parse(message.ToString());
                    transaction.TransactionID = result["TransactionID"].ToString();
                    transaction.CountryCode = result["CountryCode"].ToString();
                    transaction.RecordStatus = result["Record"]["RecordStatus"].ToString();
                }
                _httpClient.Dispose();
            }

            return transaction;
        }

        private static StringContent GetStringContent(dynamic content)
        {
            if (object.ReferenceEquals(content, null))
            {
                return null;
            }
            return new StringContent(JsonConvert.SerializeObject(content, _jsonSerializerSettings), Encoding.UTF8, "application/json");
        }
    }
}
