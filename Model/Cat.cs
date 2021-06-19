using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace blazorTest.Model
{
    public class Cat
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }

        //public Cat() { }

        //public Cat(string Name, string LastName, int Age)
        //{
        //    this.Name = Name;
        //    this.LastName = LastName;
        //    this.Age = Age;
        //}
    }
}
