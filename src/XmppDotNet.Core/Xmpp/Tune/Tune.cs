using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.PubSub;

namespace XmppDotNet.Xmpp.Tune
{
    /// <summary>
    /// XEP-0118: User Tune
    /// </summary>
    [XmppTag(Name = "tune", Namespace = Namespaces.Tune)]
    public class Tune : XmppXElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tune"/> class.
        /// </summary>
        public Tune() : base(Namespaces.Tune, "tune")
        {
        }

        /// <summary>
        /// Gets or sets the artist or performer of the song or piece.
        /// </summary>
        public string Artist
        {
            get { return GetTag("artist"); }
            set { SetTag("artist", value); }
        }

        /// <summary>
        /// Gets or sets the duration of the song or piece in seconds.
        /// </summary>
        public long Length
        {
            get { return GetTagLong("length"); }
            set { SetTag("length", value); }
        }

        /// <summary>
        /// Gets or sets the user's rating of the song or piece, from 1 (lowest) to 10 (highest).
        /// </summary>
        public int Rating
        {
            get { return GetTagInt("rating"); }
            set { SetTag("rating", value); }
        }

        /// <summary>
        /// Gets or sets the collection (e.g., album) or other source (e.g., a band website that hosts streams or audio files).
        /// </summary>
        public string Source
        {
            get { return GetTag("source"); }
            set { SetTag("source", value); }
        }

        /// <summary>
        /// Gets or sets the title of the song or piece.
        /// </summary>
        public string Title
        {
            get { return GetTag("title"); }
            set { SetTag("title", value); }
        }

        /// <summary>
        /// Gets or sets a unique identifier for the tune; e.g., the track number within a collection or the specific URI for the object (e.g., a stream or audio file).
        /// </summary>
        public string Track
        {
            get { return GetTag("track"); }
            set { SetTag("track", value); }
        }

        /// <summary>
        /// gets or sets a URI or URL pointing to information about the song, collection, or artist.
        /// </summary>
        public System.Uri Uri
        {
            get { return new System.Uri(GetTag("uri")); }
            set { SetTag("uri", value.ToString()); }
        }

        /// <summary>
        /// Creates the Pubsub XmppXElement for this Tune.
        /// </summary>
        /// <returns></returns>
        public PubSub.PubSub ToPubSub()
        {
            return new PubSub.PubSub
            {
                Publish = new Publish(new Item(this)) { Node = Namespaces.Tune }
            };
        }
    }
}
