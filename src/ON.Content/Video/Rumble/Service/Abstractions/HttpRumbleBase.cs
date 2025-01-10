using Microsoft.Extensions.Options;
using ON.Content.Rumble.Service.Models;
using ON.Content.Rumble.Service;
using RestSharp;

namespace ON.Content.Video.Rumble.Service.Abstractions
{
    public abstract class HttpRumbleBase
    {
        private readonly ILogger<ServiceOpsService> _logger;
        private readonly IOptions<AppSettings> _appSettings;

        protected HttpRumbleBase(ILogger<ServiceOpsService> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        private async Task<RestResponse> MakeHttpRequestAsync(RestRequest request)
        {
            var client = new RestClient();
            var response = await client.GetAsync(request);
            return response;
        }
    }
}
