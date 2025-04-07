using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Клас для співробітників зоопарку (S - Single Responsibility)
    class ZooWorker
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public ZooWorker(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}