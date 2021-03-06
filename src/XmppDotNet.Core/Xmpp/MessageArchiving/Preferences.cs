using System.Collections.Generic;
using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "pref", Namespace = Namespaces.Archiving)]
    public class Preferences : XmppXElement
    {
        #region Schema
        /*
          <xs:element name='pref'>
            <xs:complexType>
              <xs:sequence>
                <xs:element ref='auto' minOccurs='0' maxOccurs='1'/>
                <xs:element ref='default' minOccurs='0' maxOccurs='1'/>
                <xs:element ref='item' minOccurs='0' maxOccurs='unbounded'/>
                <xs:element ref='method' minOccurs='0' maxOccurs='unbounded'/>
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        */
        #endregion

        #region Xml samples
        /*
        <iq type='result' id='pref1' to='juliet@capulet.com/chamber'>
          <pref xmlns='urn:xmpp:archive'>
            <auto save='false'/>
            <default expire='31536000' otr='concede' save='body'/>
            <item jid='romeo@montague.net' otr='require' save='false'/>
            <item expire='630720000' jid='benvolio@montague.net' otr='forbid' save='message'/>
            <session thread='ffd7076498744578d10edabfe7f4a866' save='body'/>
            <method type='auto' use='forbid'/>
            <method type='local' use='concede'/>
            <method type='manual' use='prefer'/>
          </pref>
        </iq>
        */
        #endregion
        
        public Preferences() : base(Namespaces.Archiving, "pref")
        {
        }

        public Auto Auto
        {
            get { return Element<Auto>(); }
            set { Replace(value); }
        }

        public Default Default
        {
            get { return Element<Default>(); }
            set { Replace(value); }
        }

        public Session Session
        {
            get { return Element<Session>(); }
            set { Replace(value); }
        }

        #region methods
        public IEnumerable<Method> GetMethods()
        {
            return Elements<Method>();
        }

        public Method AddMethod()
        {
            var method = new Method();
            Add(method);

            return method;
        }

        public Preferences AddMethod(Method method)
        {
            Add(method);
            return this;
        }
        #endregion
    }
}
