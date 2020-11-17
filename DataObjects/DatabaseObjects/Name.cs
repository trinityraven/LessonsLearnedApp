using DataObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataObjects.DatabaseObjects
{
    public class Name
    {
        [Key]
        public int Id { get; set; }

        public List<NameElement> Names { get; set; }
        public Dictionary<int, NameElementType> Pattern { get; set; }

        public DateTime EffectiveFrom { get; set; } = DateTime.Now;
        public DateTime? EffectiveTo { get; set; } = null;

        //TODO: Add Builder
        //TODO: Add Testing
    }
}
