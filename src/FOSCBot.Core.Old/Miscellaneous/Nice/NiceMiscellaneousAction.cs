﻿// using FOSCBot.Common.Helper;
// using Navigator.Context;
// using Navigator.Providers.Telegram.Actions.Messages;
//
// namespace FOSCBot.Core.Old.Miscellaneous.Nice;
//
// public class NiceMiscellaneousAction : MessageAction
// {
//     public NiceMiscellaneousAction(INavigatorContextAccessor navigatorContextAccessor) : base(navigatorContextAccessor)
//     {
//     }
//
//     public override bool CanHandleCurrentContext()
//     {
//         return RandomProvider.GetThreadRandom().NextDouble() < 0.7d && (Message.Text?.Contains("NICE") ?? false);
//     }
// }