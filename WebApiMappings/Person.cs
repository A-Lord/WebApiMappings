using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings
{
    public class Person
    {

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name , int age)
        {
            Id = StaticId.GetId();
            Name = name;
            Age = age;
        }
    }
}
