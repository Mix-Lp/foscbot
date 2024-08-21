﻿using Navigator.Context;
using Navigator.Providers.Telegram.Actions.Messages;

namespace FOSCBot.Core.Old.Miscellaneous.Elon;

public class ElonMuskMiscellaneousAction : MessageAction
{
    public ElonMuskMiscellaneousAction(INavigatorContextAccessor navigatorContextAccessor) : base(navigatorContextAccessor)
    {
    }

    public override bool CanHandleCurrentContext()
    {
        return (Message.Text?.ToLower().Contains("elon musk") ?? false) ||
               (Message.Text?.ToLower().StartsWith("elon") ?? false) ||
               (Message.Text?.ToLower().Contains("elon ") ?? false) ||
               (Message.Text?.ToLower().EndsWith(" elon") ?? false) ||
               (Message.Text?.ToLower().StartsWith("musk") ?? false) ||
               (Message.Text?.ToLower().Contains("musk ") ?? false) ||
               (Message.Text?.ToLower().EndsWith(" musk") ?? false);
    }
}