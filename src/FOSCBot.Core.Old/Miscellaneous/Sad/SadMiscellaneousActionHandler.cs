﻿// using Navigator.Actions;
// using Navigator.Context;
// using Navigator.Providers.Telegram;
// using Telegram.Bot;
//
// namespace FOSCBot.Core.Old.Miscellaneous.Sad;
//
// public class SadMiscellaneousActionHandler : ActionHandler<SadMiscellaneousAction>
// {
//     public SadMiscellaneousActionHandler(INavigatorContextAccessor navigatorContextAccessor) : base(navigatorContextAccessor)
//     {
//     }
//
//     public override async Task<Status> Handle(SadMiscellaneousAction action, CancellationToken cancellationToken)
//     {
//         await NavigatorContext.GetTelegramClient().SendStickerAsync(NavigatorContext.GetTelegramChat()!, SadCrstian, cancellationToken: cancellationToken);
//
//         return Success();
//     }
//         
//     public static readonly string SadCrstian = "CAACAgQAAxkBAAI5DF59uqkJYnqzc5LcnEC_bdp0rerIAAJsAwACmOejAAG_qYNUT_L_exgE";
// }