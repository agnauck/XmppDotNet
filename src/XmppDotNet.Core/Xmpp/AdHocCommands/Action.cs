using System;
using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.AdHocCommands
{
    [Flags]
    public enum Action
    {
        [Name("none")]
        None = -1,

        [Name("next")]
        Next = 1,

        [Name("prev")]
        Prev = 2,

        [Name("complete")]
        Complete = 4,

        [Name("execute")]
        Execute = 8,

        [Name("cancel")]
        Cancel = 16       
    }
}
