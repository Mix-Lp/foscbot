namespace FOSCBot.Infrastructure.Contract.Client;

public interface IFoscbotElevenLabsClient
{
    Task<List<byte>> Get(String text, CancellationToken cancellationToken = default);
}