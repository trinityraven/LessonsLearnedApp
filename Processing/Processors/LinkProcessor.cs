using DataObjects.Enums;
using DataObjects.Extensions;
using Processing.Interfaces;
using System.Collections.Generic;

namespace Processing.Processors
{
    public class LinkProcessor : ILinkProcessor
    {
        public Dictionary<string, string> GetLinkTypes()
        {
            const LinkType LINK_TYPES = LinkType.Web;
            return LINK_TYPES.GetValueDictionary();
        }
    }
}
