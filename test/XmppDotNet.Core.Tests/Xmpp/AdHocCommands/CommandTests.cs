namespace XmppDotNet.Tests.Xmpp.AdHocCommands
{
    using XmppDotNet.Xml;
    using XmppDotNet.Xmpp.AdHocCommands;
    using XmppDotNet.Xmpp.Client;
    using Shouldly;
    using Xunit;

    public class CommandTests
    {
        const string NOTE_VALUE = "Service 'httpd' has been configured.";
        private const string XML1 = @"<command xmlns='http://jabber.org/protocol/commands'
                       sessionid='config:20020923T213616Z-700'
                       node='config'
                       status='completed'>
                <note type='info'>" + NOTE_VALUE + @"</note>
              </command>";

        private const string XML2 = @"<command xmlns='http://jabber.org/protocol/commands'>                       
                <actions execute='next'>
                  <next/>
                </actions>        
              </command>";

        private const string XML3 = @"<command xmlns='http://jabber.org/protocol/commands' node='http://jabber.org/protocol/admin#add-user' action='execute' />";
        
        [Fact]
        public void Test1()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML1);
            xmpp1.ShouldBeOfType<Command>();
            if (xmpp1 is Command cmd)
            {
                cmd.SessionId.ShouldBe("config:20020923T213616Z-700");
                cmd.Node.ShouldBe("config");
                cmd.Status.ShouldBe(Status.Completed);

                var note = cmd.Note;
                if (note != null)
                {
                    note.Type.ShouldBe(NoteType.Info);
                    note.Value.ShouldBe( NOTE_VALUE);
                    note.Value.ShouldNotBe("dummy");
                }
            }
        }

        [Fact]
        public void Test2()
        {
            var cmd = new Command
            {
                SessionId = "config:20020923T213616Z-700",
                Node = "config",
                Status = Status.Completed,
                Note = new Note
                {
                    Type = NoteType.Info,
                    Value = NOTE_VALUE
                }
            };

            cmd.ShouldBe(XML1);
        }


        [Fact]
        public void Test3()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML2);
            xmpp1.ShouldBeOfType<Command>();

            if (xmpp1 is Command cmd)
            {
                var actions = cmd.Actions;
                if (actions != null)
                {
                    Assert.Equal(Action.Next, actions.Execute);
                    Assert.True(actions.Next);
                    Assert.False(actions.Previous);
                    Assert.Equal(Action.Next, actions.Action);
                    Assert.NotEqual(Action.Next | Action.Prev, actions.Action);

                    // modify actions now and test again
                    actions.Action = Action.Next | Action.Prev;
                    Assert.Equal(Action.Next | Action.Prev, actions.Action);
                    Assert.NotEqual(Action.Next | Action.Complete, actions.Action);
                }
            }
        }

        [Fact]
        public void Test4()
        {
            var cmd = new Command()
            {
                Node = "http://jabber.org/protocol/admin#add-user",
                Action = Action.Execute
            };

            cmd.ShouldBe(XML3);
        }

        [Fact]
        public void TestOnlineUsers()
        {
            string XML1 = @"<iq id='get-online-users-list-1'
                to='shakespeare.lit'
                type='set'
                xmlns='jabber:client'>
                <command xmlns='http://jabber.org/protocol/commands' 
                           action='execute'
                           node='http://jabber.org/protocol/admin#get-online-users-list'/>
                </iq>";

            var iq = new Iq
            {
                To = "shakespeare.lit",
                Id = "get-online-users-list-1",
                Type = XmppDotNet.Xmpp.IqType.Set
            };

            var cmd = new Command()
            {
                Action = Action.Execute,
                Node = "http://jabber.org/protocol/admin#get-online-users-list"
            };

            iq.Add(cmd);

            iq.ShouldBe(XML1);
        }
    }
}
