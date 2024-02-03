using System.Collections.Generic;
using System.Linq;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Disco
{
    public abstract class FeatureContainer : XmppXElement
    {
        public FeatureContainer(string ns, string tag) :
            base(ns, tag)
        {
        }
        
        /// <summary>
        /// Adds a feature.
        /// </summary>
        /// <returns></returns>
        public Feature AddFeature()
        {
            var feat = new Feature();
            Add(feat);
            
            return feat;
        }

        /// <summary>
        /// Adds a feature.
        /// </summary>
        /// <param name="feature">The feature.</param>
        public void AddFeature(Feature feature)
        {
            Add(feature);
        }
        
        /// <summary>
        /// Gets all Features
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Feature> GetFeatures()
        {
            return Elements<Feature>();
        }

        /// <summary>
        /// Check if a feature is supported
        /// </summary>
        /// <param name="var">The var.</param>
        /// <returns>
        /// 	<c>true</c> if the specified feature exists; otherwise, <c>false</c>.
        /// </returns>
        public bool HasFeature(string var)
        {
            return GetFeatures().Any(feat => feat.Var == var);
        }

    }
}