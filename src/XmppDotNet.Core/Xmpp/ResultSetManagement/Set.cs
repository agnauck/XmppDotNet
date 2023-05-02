using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.ResultSetManagement
{
    /// <summary>
    /// XEP-0059: Result Set Management
    /// </summary>
    [XmppTag(Name = "set", Namespace = Namespaces.Rsm)]
    public class Set : XmppXElement
    {
        #region Schema
        /*
         <xs:element name='set'>
            <xs:complexType>
              <xs:sequence>
                <xs:element name='after' type='xs:string' minOccurs='0' maxOccurs='1'/>
                <xs:element name='before' type='xs:string' minOccurs='0' maxOccurs='1'/>
                <xs:element name='count' type='xs:int' minOccurs='0' maxOccurs='1'/>
                <xs:element ref='first' minOccurs='0' maxOccurs='1'/>
                <xs:element name='index' type='xs:int' minOccurs='0' maxOccurs='1'/>
                <xs:element name='last' type='xs:string' minOccurs='0' maxOccurs='1'/>
                <xs:element name='max' type='xs:int' minOccurs='0' maxOccurs='1'/>
              </xs:sequence>
            </xs:complexType>
         </xs:element>
        */
        #endregion

        public Set() : base(Namespaces.Rsm, "set")
        {
        }

        /// <summary>
        /// Gets or sets the maximum for limiting the number of items.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public int Max
        {
            get => GetTagInt("max");
            set => SetTag("max", value);
        }

        public int Index
        {
            get => GetTagInt("index");
            set => SetTag("index", value);
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get => GetTagInt("count");
            set => SetTag("count", value);
        }

        public string After
        {
            get => GetTag("after");
            set => SetTag("after", value);
        }

        public string Before
        {
            get => GetTag("before");
            set => SetTag("before", value);
        }

        /// <summary>
        /// Gets or sets a reference the last item.
        /// </summary>
        /// <value>
        /// The last.
        /// </value>
        public string Last
        {
            get => GetTag("last");
            set => SetTag("last", value);
        }

        /// <summary>
        /// Gets or sets a reference the first item.
        /// </summary>
        /// <value>
        /// The first.
        /// </value>
        public First First
        {
            get => Element<First>();
            set => Replace(value);
        }
    }
}
