using Microsoft.Extensions.Options;
using ON.Content.Rumble.Service;
using ON.Content.Rumble.Service.Models;
using ON.Fragments.Content;
using RestSharp;

namespace ON.Content.Video.Rumble.Service.Data
{
    public class HttpRumbleLivestreamProvider : HttpRumbleBase
    {
        public HttpRumbleLivestreamProvider(ILogger<ServiceOpsService> logger, IOptions<AppSettings> appsettings) : base(logger, appsettings) { }

        public async Task<RumbleLivestreamResponse> GetLivestreamAsync(RumbleLivestreamRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
