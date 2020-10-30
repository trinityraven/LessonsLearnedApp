using System;
using System.ComponentModel.DataAnnotations;

namespace DataObjects.DatabaseObjects
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public Name Name { get; set; }
    }
}
