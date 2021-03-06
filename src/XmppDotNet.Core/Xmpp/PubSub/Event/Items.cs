using System.Collections.Generic;
using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.PubSub.Event
{
    [XmppTag(Name = "items", Namespace = Namespaces.PubsubEvent)]
    public class Items : XmppXElement
    {
        public Items() : base(Namespaces.PubsubEvent, "items")
        {
        }

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        /// <value>The node.</value>
        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }

        #region << Item properties >>
        /// <summary>
        /// Adds an item.
        /// </summary>
        /// <returns></returns>
        public Item AddItem()
        {
            var item = new Item();
            Add(item);

            return item;
        }
        
        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem(Item item)
        {
            Add(item);
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> GetItems()
        {
            return Elements<Item>();
        }

        /// <summary>
        /// Sets the Items.
        /// </summary>
        /// <param name="items">The Items.</param>
        public void SetItems(IEnumerable<Item> items)
        {
            RemoveAllItems();
            foreach (Item item in items)
                AddItem(item);
        }
        
        /// <summary>
        /// Removes all Items.
        /// </summary>
        public void RemoveAllItems()
        {
            RemoveAll<Item>();
        }
        #endregion

        #region << Retract properties >>
        /// <summary>
        /// Adds the retract.
        /// </summary>
        /// <returns></returns>
        public Retract AddRetract()
        {
            var retract = new Retract();
            Add(retract);

            return retract;
        }

        /// <summary>
        /// Adds the retract.
        /// </summary>
        /// <param name="retract">The retract.</param>
        public void AddRetract(Retract retract)
        {
            Add(retract);
        }

        /// <summary>
        /// Gets the retracts.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Retract> GetRetracts()
        {
            return Elements<Retract>();
        }

        /// <summary>
        /// Sets the retracts.
        /// </summary>
        /// <param name="retracts">The retract.</param>
        public void SetRetracts(IEnumerable<Retract> retracts)
        {
            RemoveAllRetracts();
            foreach (Retract retract in retracts)
                AddRetract(retract);
        }

        /// <summary>
        /// Removes all retracts.
        /// </summary>
        public void RemoveAllRetracts()
        {
            RemoveAll<Retract>();
        }
        #endregion
    }
}
