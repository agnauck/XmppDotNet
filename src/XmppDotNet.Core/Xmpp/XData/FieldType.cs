using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// Field Types
    /// </summary>
    public enum FieldType
    {
        /// <summary>
        /// a unknown fieldtype
        /// </summary>
        Unknown,

        /// <summary>
        /// The field enables an entity to gather or provide an either-or choice between two options. The allowable values are 1 for yes/true/assent and 0 for no/false/decline. The default value is 0.
        /// </summary>
        [Name("boolean")]
        Boolean,

        /// <summary>
        /// The field is intended for data description (e.g., human-readable text such as "section" headers) rather than data gathering or provision. The <value/> child SHOULD NOT contain newlines (the \n and \r characters); instead an application SHOULD generate multiple fixed fields, each with one <value/> child.
        /// </summary>
        [Name("fixed")]
        Fixed,

        /// <summary>
        ///	The field is not shown to the entity providing information, but instead is returned with the form.
        ///	</summary>
        [Name("hidden")]
        Hidden,

        /// <summary>
        /// The field enables an entity to gather or provide multiple Jabber IDs.
        /// </summary>
        [Name("jid-multi")]
        JidMulti,

        /// <summary>
        /// The field enables an entity to gather or provide a single Jabber ID.	
        /// </summary>
        [Name("jid-single")]
        JidSingle,

        /// <summary>
        /// The field enables an entity to gather or provide one or more options from among many.
        /// </summary>
        [Name("list-multi")]
        ListMulti,

        /// <summary>
        /// The field enables an entity to gather or provide one option from among many.
        /// </summary>
        [Name("list-single")]
        ListSingle,

        /// <summary>
        /// The field enables an entity to gather or provide multiple lines of text.
        /// </summary>
        [Name("text-multi")]
        TextMulti,

        /// <summary>
        /// password style textbox.
        /// The field enables an entity to gather or provide a single line or word of text, which shall be obscured in an interface (e.g., *****).
        /// </summary>		
        [Name("text-private")]
        TextPrivate,

        /// <summary>
        /// The field enables an entity to gather or provide a single line or word of text, which may be shown in an interface. This field type is the default and MUST be assumed if an entity receives a field type it does not understand.
        /// </summary>
        [Name("text-single")]
        TextSingle
    }
}
