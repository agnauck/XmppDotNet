using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Sasl
{
    /// <summary>
    /// Sasl failure object.
    /// </summary>
    [XmppTag(Name = "failure", Namespace = Namespaces.Sasl)]
    public class Failure : XmppXElement
    {
        #region << Constructors >>
        /// <summary>
        /// Initializes a new instance of the <see cref="Failure"/> class.
        /// </summary>
        public Failure() : base(Namespaces.Sasl, "failure")
		{			
		}
        
        public Failure(string ns) : base(ns, "failure")
        {			
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Failure"/> class.
        /// </summary>
        /// <param name="condition">The condition.</param>
        public Failure(FailureCondition condition) : this()
        {
            Condition = condition;
        }
        #endregion
        
        /// <summary>
        /// The failure condition
        /// </summary>
        public FailureCondition Condition
        {
            get
            {
                foreach (var failureCondition in Enum.GetValues<FailureCondition>().ToEnum<FailureCondition>())
                {
                     if (HasTag(Namespaces.Sasl, failureCondition.GetName()))
                        return failureCondition;
                }
                return FailureCondition.UnknownCondition;
            }
            set
            {
                if (value != FailureCondition.UnknownCondition)
                    SetTag(Namespaces.Sasl, value.GetName(), null);
            }
        }

        /// <summary>
        /// An optional text description for the authentication failure.
        /// </summary>
        public new string Text
        {
            get { return GetTag("text"); }
            set { SetTag("text", value); }
        }
	} 
}
