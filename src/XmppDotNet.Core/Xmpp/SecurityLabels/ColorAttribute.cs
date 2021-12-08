using System;
using System.Collections.Generic;
using System.Text;

namespace XmppDotNet.Xmpp.SecurityLabels
{
    public class ColorAttribute : Attribute
    {
        public string Hex { get; set; }
    }
}
