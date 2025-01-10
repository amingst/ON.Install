using Google.Protobuf;
using Microsoft.Extensions.Options;
using ON.Content.Rumble.Service.Models;
using ON.Content.Video.Rumble.Service.Abstractions;
using ON.Fragments.Content.Video.Rumble;

namespace ON.Content.Video.Rumble.Service.Data
{
    // TODO: Fix where the data is stored
    public class FileSystemRumbleLivestreamChannelProvider : IFileSystemRumbleLivestreamChannelProvider
    {
        private readonly DirectoryInfo _dataDir;

        public FileSystemRumbleLivestreamChannelProvider(IOptions<AppSettings> settings)
        {
            var root = new DirectoryInfo(settings.Value.DataStore);
            root.Create();
            _dataDir = root.CreateSubdirectory("livestream-channels");
        }

        public async Task<GetRumbleLivestreamChannelUrlResponse> GetRumbleLivestreamChannelUrlAsync(RumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken)
        {
            var file = _dataDir.EnumerateFiles().Where(c => c.Name == request.ChannelId).FirstOrDefault();

            if (file == null)
            {
                return new GetRumbleLivestreamChannelUrlResponse();
            }

            var channelUrlRecord = await ReadFromFileAsync(file, cancellationToken);

            return new GetRumbleLivestreamChannelUrlResponse()
            {
                Channel = channelUrlRecord,
            };
        }

        public async Task<ListRumbleLivestreamChannelUrlsResponse> ListRumbleLivestreamChannelUrlsAsync(ListRumbleLivestreamChannelUrlsRequest request, CancellationToken cancellationToken)
        {
            var files = _dataDir.EnumerateFiles();

            var response = new ListRumbleLivestreamChannelUrlsResponse();

            if (files == null || files.Count() == 0)
            {
                return response;
            }

            foreach ( var file in files)
            {
                var channelUrlRecord = await ReadFromFileAsync(file, cancellationToken);

                if (channelUrlRecord != null)
                {
                    response.Channels.Add(channelUrlRecord);
                }
            }

            return response;
        }

        public async Task<MutateRumbleLivestreamChannelUrlResponse> MutateRumbleLivestreamChannelUrlAsync(MutateRumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken)
        {
            var file = _dataDir.EnumerateFiles().Where(f => f.Name == request.Channel.ChannelId).FirstOrDefault();

            try
            {
                if (file == null)
                {
                    await File.WriteAllBytesAsync(request.Channel.ChannelId, request.Channel.ToByteArray());
                }
                else
                {
                    await File.WriteAllBytesAsync(file.FullName, request.Channel.ToByteArray());
                }

                return new MutateRumbleLivestreamChannelUrlResponse()
                {
                    IsSuccess = true,
                };
            }
            catch (Exception ex)
            {
                return new MutateRumbleLivestreamChannelUrlResponse()
                {
                    Error = ex.Message,
                    IsSuccess = false
                };
            }
        }

        // TODO: Make More Readable And Remove Async Name
        public  Task<MutateRumbleLivestreamChannelUrlResponse> RemoveRumbleLivestreamChannelUrlAsync(RumbleLivestreamChannelUrlRequest request, CancellationToken cancellationToken)
        {
            var file = _dataDir.EnumerateFiles().Where(f => f.Name == request.ChannelId).FirstOrDefault();

            if (file == null)
            {
                return Task.FromResult(new MutateRumbleLivestreamChannelUrlResponse());
            }

            if (!file.Exists)
            {
                return Task.FromResult(new MutateRumbleLivestreamChannelUrlResponse
                {
                    IsSuccess = false,
                    Error = "Record Does Not Exist"
                });
            }

            try
            {
                file.Delete();
                
                if (file.Exists)
                {
                    return Task.FromResult(new MutateRumbleLivestreamChannelUrlResponse
                    {
                        IsSuccess = false,
                        Error = "Failed To Delete Record"
                    });
                } else
                {
                    return Task.FromResult(new MutateRumbleLivestreamChannelUrlResponse
                    {
                        IsSuccess = true
                    });
                }
            }
            catch (Exception ex) 
            {
                return Task.FromResult(new MutateRumbleLivestreamChannelUrlResponse
                {
                    IsSuccess = false,
                    Error = ex.Message
                });
            }
        }

        private async Task<RumbleLivestreamChannelRecord?> ReadFromFileAsync(FileInfo file, CancellationToken cancellationToken)
        {
            var bytes = await File.ReadAllBytesAsync(file.FullName);

            if (bytes == null)
            {
                return null;
            }

            var channelUrlRecord = RumbleLivestreamChannelRecord.Parser.ParseFrom(bytes);

            return channelUrlRecord;
        }
    }
}
