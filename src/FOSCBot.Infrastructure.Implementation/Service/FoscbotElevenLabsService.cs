using FOSCBot.Infrastructure.Contract.Client;
using FOSCBot.Infrastructure.Contract.Service;
using Microsoft.Extensions.Logging;

namespace FOSCBot.Infrastructure.Implementation.Service;

public class FoscbotElevenLabsService: IFoscbotElevenLabsClient
{
    private readonly ILogger<FoscbotElevenLabsService> _logger;
    private readonly IFoscbotElevenLabsClient _elevenLabsClient;

    public FoscbotElevenLabsService(ILogger<FoscbotElevenLabsService> logger, IFoscbotElevenLabsClient elevenLabsClient)
    {
        _logger = logger;
        _elevenLabsClient = elevenLabsClient;
    }

    public async Task<List<byte>> Get(string text, CancellationToken cancellationToken = default)
    {
        try
        {
            var audio = await _elevenLabsClient.Get(text, cancellationToken);

            return audio;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Unhandled error generating ElevenLabs audio.");

            return default;
        }
    }
}