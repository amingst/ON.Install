using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using ON.Authentication;
using ON.Content.Rumble.Service;
using ON.Content.Rumble.Service.Models;
using ON.Content.Video.Rumble.Service.Abstractions;
using ON.Content.Video.Rumble.Service.Data;
using ON.Fragments.Content.Video.Rumble;

namespace ON.Content.Video.Rumble.Service.Services
{
    // TODO: Add Authentication
    public class RumbleLivestreamService : RumbleLivestreamInterface.RumbleLivestreamInterfaceBase
    {
        private readonly ILogger<ServiceOpsService> _logger;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IFileSystemRumbleLivestreamChannelProvider _channelProvider;

        public RumbleLivestreamService(ILogger<ServiceOpsService> logger, IOptions<AppSettings> appSettings, IFileSystemRumbleLivestreamChannelProvider channelProvider)
        {
            _logger = logger;
            _appSettings = appSettings;
            _channelProvider = channelProvider;
        }

        // TODO: Split Stream Key From Response if not admin
        public override async Task<RumbleLivestreamResponse> GetLivestream(RumbleLivestreamRequest request, ServerCallContext context)
        {
            var provider = new HttpRumbleLivestreamProvider(_logger, _appSettings);
            try
            {
                var livestreamChannel = await GetRumbleLivestreamChannelUrl(new RumbleLivestreamChannelUrlRequest() { ChannelId = request.ChannelId }, context);

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

        public override async Task<MutateRumbleLivestreamChannelUrlResponse> MutateRumbleLivestreamChannelUrl(MutateRumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            return await _channelProvider.MutateRumbleLivestreamChannelUrlAsync(request, context.CancellationToken);
        }
        public override async Task<MutateRumbleLivestreamChannelUrlResponse> RemoveRumbleLivestreamChannelUrl(RumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            return await _channelProvider.RemoveRumbleLivestreamChannelUrlAsync(request, context.CancellationToken);
        }
        public override async Task<GetRumbleLivestreamChannelUrlResponse> GetRumbleLivestreamChannelUrl(RumbleLivestreamChannelUrlRequest request, ServerCallContext context)
        {
            return await _channelProvider.GetRumbleLivestreamChannelUrlAsync(request, context.CancellationToken);
        }
        public override async Task<ListRumbleLivestreamChannelUrlsResponse> ListRumbleLivestreamChannelUrls(ListRumbleLivestreamChannelUrlsRequest request, ServerCallContext context)
        {
            return await _channelProvider.ListRumbleLivestreamChannelUrlsAsync(request, context.CancellationToken);
        }
    }
}
