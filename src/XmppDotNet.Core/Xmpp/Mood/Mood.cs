using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.PubSub;

namespace XmppDotNet.Xmpp.Mood
{
    /// <summary>
    /// XEP-0107: User Mood
    /// </summary>
    [XmppTag(Name = "mood", Namespace = Namespaces.Mood)]
    public class Mood : XmppXElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mood"/> class.
        /// </summary>
        public Mood() : base(Namespaces.Mood, "mood")
        {
        }
        
        /// <summary>
        /// Gets or sets the optional mood text.
        /// </summary>
        /// <value>
        /// The mood text.
        /// </value>
        public string MoodText
        {
            get { return GetTag("text"); }
            set
            {
                if (value == null)
                    RemoveTag("text");
                else
                    SetTag("text", value);
            }
        }

        /// <summary>
        /// Gets or sets the user mood.
        /// </summary>
        /// <value>
        /// The user mood.
        /// </value>
        public Moods UserMood
        {
            get
            {
                foreach (var mood in Enum.GetValues<Moods>().ToEnum<Moods>())
                {
                    if (HasTag(mood.GetName()))
                        return mood;
                }
                // if none found return None
                return Moods.None;
            }
            set
            {
                RemoveAllMoods();
                if (value != Moods.None)
                    AddTag(value.GetName());
            }
        }

        /// <summary>
        /// Creates the Pubsub XmppXElement for this Mood.
        /// </summary>
        /// <returns></returns>
        public PubSub.PubSub ToPubSub()
        {
            return new PubSub.PubSub
                {
                    Publish = new Publish(new Item(this)) {Node = Namespaces.Mood}
                };
        }

        /// <summary>
        /// Removed all User Mood tags
        /// </summary>
        private void RemoveAllMoods()
        {
            foreach (var mood in Enum.GetValues<Moods>().ToEnum<Moods>())
                RemoveTag(mood.GetName());
        }
    }
}
