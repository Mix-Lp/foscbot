using ElevenLabs;
using ElevenLabs.TextToSpeech;
using FOSCBot.Infrastructure.Contract.Client;
using Microsoft.Extensions.Options;

namespace FOSCBot.Infrastructure.Implementation.Client;

public class FoscbotElevenLabsClient : IFoscbotElevenLabsClient
{
    protected readonly ElevenLabsClient Client;
    protected readonly ElevenLabsClientOptions Options;

    public FoscbotElevenLabsClient(ElevenLabsClient client, IOptions<ElevenLabsClientOptions> options)
    {
        Client = client;
        Options = options.Value;
    }

    public async Task<List<byte>> Get(string text, CancellationToken cancellationToken = default)
    {
        var voice = (await Client.VoicesEndpoint.GetAllVoicesAsync()).FirstOrDefault();
        var request = new TextToSpeechRequest(voice, text);
        var voiceClip = await Client.TextToSpeechEndpoint.TextToSpeechAsync(request);
        return voiceClip.ClipData.ToArray().ToList();
    }

    public class ElevenLabsClientOptions
    {
        public string ApiKey { get; set; }
    }
}