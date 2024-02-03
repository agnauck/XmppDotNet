using System.Collections.Generic;
using System.Linq;
using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.XData;

namespace XmppDotNet.Xmpp.Disco
{
    /// <summary>
    /// Disco Information
    /// </summary>
    [XmppTag(Name = Tag.Query, Namespace = Namespaces.DiscoInfo)]
    public class Info : FeatureContainer
    {
        #region << Constructors >>
        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
        public Info()
            : base(Namespaces.DiscoInfo, Tag.Query)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public Info(string node)
            : this()
        {
            Node = node;
        }
        #endregion

        /// <summary>
        /// Optional node Attrib
        /// </summary>
        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }


        /// <summary>
        /// Adds a identity.
        /// </summary>
        /// <returns></returns>
        public Identity AddIdentity()
        {
            var id = new Identity();
            Add(id);            
            return id;
        }

        /// <summary>
        /// Adds a identity.
        /// </summary>
        /// <param name="id">The id.</param>
        public void AddIdentity(Identity id)
        {
            Add(id);
        }
        
        /// <summary>
        /// Gets the identities.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Identity> GetIdentities()
        {         
            return Elements<Identity>();            
        }
        
        /// <summary>
        /// Gets all XData Froms
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Data> GetDataForms()
        {
            return Elements<Data>();
        }

        /// <summary>
        /// Add a xdata form
        /// </summary>
        /// <param name="form"></param>
        public void AddDataForm(Data form)
        {
            Add(form);
        }

        #region << Extension Properties >>
        /// <summary>
        /// Gets or sets the Xdata object.
        /// </summary>
        /// <value>The X data.</value>
        public Data XData
        {
            get { return Element<Data>(); }
            set { Replace(value); }
        }
        #endregion
    }
}
