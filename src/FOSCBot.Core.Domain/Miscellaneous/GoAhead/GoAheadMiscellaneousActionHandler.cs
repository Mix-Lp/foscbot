using System.Threading;
using System.Threading.Tasks;
using FOSCBot.Core.Domain.Resources;
using MediatR;
using Navigator.Abstractions;
using Navigator.Abstractions.Extensions;
using Navigator.Extensions.Actions;

namespace FOSCBot.Core.Domain.Miscellaneous.GoAhead;

public class GoAheadMiscellaneousActionHandler : ActionHandler<GoAheadMiscellaneousAction>
{
    public GoAheadMiscellaneousActionHandler(INavigatorContext ctx) : base(ctx)
    {
    }

    public override async Task<Unit> Handle(GoAheadMiscellaneousAction request, CancellationToken cancellationToken)
    {
        await Ctx.Client.SendVideoAsync(Ctx.GetTelegramChat(), CoreLinks.GoAhead, 
            cancellationToken: cancellationToken, caption: "SSSSSSSSSSSUCK YOUR OWN COCKKKKK");
        return Unit.Value;
    }
}