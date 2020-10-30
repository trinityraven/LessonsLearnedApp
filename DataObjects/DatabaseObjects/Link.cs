using DataObjects.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataObjects.DatabaseObjects
{
    public class Link
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public LinkType LinkType { get; set; }

        public override string ToString() => $"{Name} ({Description}) {LinkType}: {URL}";
    }
}