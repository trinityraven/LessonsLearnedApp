using DataObjects.Enums;

namespace DataObjects.DatabaseObjects
{
    public class Link
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public LinkType LinkType { get; set; }

        public override string ToString() => $"{Name} ({Description}) {LinkType}: {URL}";
    }
}