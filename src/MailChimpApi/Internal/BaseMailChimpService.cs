using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MailChimpApi.Internal.Dto;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MailChimpApi.Internal
{
    internal abstract class BaseMailChimpService
    {
        protected readonly HttpClient _client;
        protected readonly ILogger<BaseMailChimpService> _logger;
        protected string _apiKey;

        protected BaseMailChimpService(HttpClient client, IOptions<MailChimpApiOptions> options, ILogger<BaseMailChimpService> logger)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            _apiKey = options.Value.ApiKey;
            client.BaseAddress = new Uri(options.Value.MailChimpUri);

            _client = client;
            _logger = logger;
        }

        protected async Task<TResponse> DeserializeResponse<TResponse>(HttpResponseMessage response)
        {
            await using Stream responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<TResponse>(responseStream);
        }

        protected async Task<TResponse> PostAsync<TResponse>(string uriPath, BaseRequest request)
        {
            // TODO: Make this nicer
            request.Key = _apiKey;

            byte[] serializedDto = SerializeDto(request);

            _logger.LogInformation(Encoding.Default.GetString(serializedDto));

            HttpResponseMessage response = await _client.PostAsync(uriPath, new ByteArrayContent(serializedDto));

            _logger.LogInformation(await response.Content.ReadAsStringAsync());

            return await DeserializeResponse<TResponse>(response);
        }

        protected byte[] SerializeDto(object dto) =>
            JsonSerializer.SerializeToUtf8Bytes(dto, new JsonSerializerOptions
            {
                Converters = {new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)},
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                IgnoreNullValues = true,
                ReadCommentHandling = JsonCommentHandling.Disallow,
                WriteIndented = false
            });
    }
}