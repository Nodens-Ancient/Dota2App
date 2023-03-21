using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Dota2App.Client
{
    public class BaseClient
    {
        private RestClient _restClient;

        private static BaseClient _client;

        private BaseClient()
        {
            _restClient = new RestClient();
        }

        public static BaseClient GetClient() =>
            _client == null ? new BaseClient() : _client;

        public T SendRestRequest<T>(string request)
        {
            var restRqst = new RestRequest(request);

            var response = _restClient.Execute(restRqst);

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
