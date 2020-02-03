using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.Model
{
    public class Animal
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
