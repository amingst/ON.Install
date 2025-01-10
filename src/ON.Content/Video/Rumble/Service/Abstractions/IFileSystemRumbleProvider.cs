using ON.Fragments.Content.Video.Rumble;

namespace ON.Content.Video.Rumble.Service.Abstractions
{
    public interface IFileSystemRumbleProvider
    {
        Task<RumbleData> GetData();
        Task SaveData(RumbleData data);
        Task<bool> IsDuplicateVideo(string videoId);
    }
}
