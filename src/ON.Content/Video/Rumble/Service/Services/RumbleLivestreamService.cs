using Grpc.Core;
using Microsoft.Extensions.Options;
using ON.Content.Rumble.Service;
using ON.Content.Rumble.Service.Models;
using ON.Content.Video.Rumble.Service.Data;
using ON.Fragments.Content.Video.Rumble;

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
                var livestreamChannel = await GetRumbleLivestreamChannelUrl(new GetRumbleLivestreamChannelUrlRequest() { ChannelId = request.ChannelId }, context);

                if (livestreamChannel == null) {
                    return new();
                }

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

        public override async Task<AddRumbleLivestreamChannelUrlResponse> AddRumbleLivestreamChannelUrl(AddRumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override async Task<EditRumbleLivestreamChannelUrlResponse> EditRumbleLivestreamChannelUrl(EditRumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override async Task<RemoveRumbleLivestreamChannelUrlResponse> RemoveRumbleLivestreamChannelUrl(RemoveRumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override async Task<GetRumbleLivestreamChannelUrlResponse> GetRumbleLivestreamChannelUrl(GetRumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override async Task<ListRumbleLivestreamChannelUrlsResponse> ListRumbleLivestreamChannelUrls(ListRumbleLivestreamChannelUrlsRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}
