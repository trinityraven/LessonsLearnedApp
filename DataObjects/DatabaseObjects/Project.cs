using System;

namespace DataObjects.DatabaseObjects
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime Start { get; set; }
        public DateTime? EndOfDevelopment { get; set; } = null;

        public DateTime? StartOfSupport => EndOfDevelopment;
        public DateTime? EndOfSupport { get; set; } = null;

        public DateTime? EnodOfLife { get; set; } = null;
    }
}
