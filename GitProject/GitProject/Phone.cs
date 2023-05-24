using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    public class Phone
    {
        private string Name { get; set; }
        public void Call(string person)
        {
            Console.WriteLine($"Calling {person}!");
        }
    }
}
