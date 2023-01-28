using System;
using Xunit.Sdk;

namespace Xunit.Categories
{
    [TraitDiscoverer(SpecDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SpecAttribute:Attribute, ITraitAttribute
    {
        public SpecAttribute()
        {

        }

        public SpecAttribute(string name)
        {
            this.Identifier = name;
        }

        public SpecAttribute(long id)
        {
            this.Identifier = id.ToString();
        }

        public string Identifier { get; private set; }

    }
}