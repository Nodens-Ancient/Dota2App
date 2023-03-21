using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Dota2App.Client
{
    public class BaseClient
    {
        private RestClient RestClient;

        private static BaseClient Client;

        private BaseClient()
        {
            RestClient = new RestClient();
        }

        private BaseClient(string baseUrl)
        {
            RestClient = new(baseUrl);
        }

        public static BaseClient GetClient() =>
            Client == null ? new BaseClient() : Client;

        public static BaseClient GetClient(string baseUrl) => Client == null ? new BaseClient(baseUrl) : Client;

        public T SendRestRequest<T>(string request)
        {
            var restRqst = new RestRequest(request);

            var response = RestClient.Execute(restRqst);

            var unparsedContent = response.Content;

            var contentType = response.ContentType;
            try
            {
                var content = JArray.Parse(unparsedContent);
                return JsonConvert.DeserializeObject<T>(content.ToString());
            }
            catch (JsonReaderException exception)
            {
                var content = JObject.Parse(unparsedContent);
                return JsonConvert.DeserializeObject<T>(content.ToString());
            }
        }
    }
}
