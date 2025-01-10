using Grpc.Core;
using Microsoft.Extensions.Options;
using ON.Content.Rumble.Service;
using ON.Content.Rumble.Service.Models;
using ON.Content.Video.Rumble.Service.Data;
using ON.Fragments.Content;

namespace ON.Content.Video.Rumble.Service.Services
{
    public class RumbleLivestreamService : RumbleLivestreamInterface.RumbleLivestreamInterfaceBase
    {
        private readonly ILogger<ServiceOpsService> _logger;
        private readonly IOptions<AppSettings> _appSettings;

        public RumbleLivestreamService(ILogger<ServiceOpsService> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        public override async Task<RumbleLivestreamResponse> GetLivestream(RumbleLivestreamRequest request, ServerCallContext context)
        {
            var provider = new HttpRumbleLivestreamProvider(_logger, _appSettings);
            try
            {
                var httpResponse = await provider.GetLivestreamAsync(request, context.CancellationToken);

                if (httpResponse == null)
                {
                    return new();
                }

                return httpResponse;
            }
            catch (Exception ex) {
                _logger.LogError(ex.Message);
                return new();
            }
            finally
            {
                provider = null;
            }
        }
    }
}
