using DataObjects.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataObjects.DatabaseObjects
{
    public class NameElement
    {
        [Key]
        public int Id { get; set; }

        public NameElementType NameType { get; set; }
        public string Value { get; set; }
        public int Index { get; set; }
    }
}
