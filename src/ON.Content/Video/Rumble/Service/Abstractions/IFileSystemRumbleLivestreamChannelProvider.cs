using ON.Fragments.Content.Video.Rumble;

namespace ON.Content.Video.Rumble.Service.Abstractions
{
    public interface IFileSystemRumbleLivestreamChannelProvider
    {
        Task<MutateRumbleLivestreamChannelUrlResponse> MutateRumbleLivestreamChannelUrlAsync(MutateRumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken);
        Task<MutateRumbleLivestreamChannelUrlResponse> RemoveRumbleLivestreamChannelUrlAsync(RumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken);
        Task<GetRumbleLivestreamChannelUrlResponse> GetRumbleLivestreamChannelUrlAsync(RumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken);
        Task<ListRumbleLivestreamChannelUrlsResponse> ListRumbleLivestreamChannelUrlsAsync(ListRumbleLivestreamChannelUrlsRequest request, CancellationToken cancellationToken);
    }
}
