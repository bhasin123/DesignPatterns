using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypePattern
{
    internal class Employee : IPrototype<Employee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public Address CurrentAddress { get; set; }
        public Address PermanentAddress { get; set; }

        public Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name - {Name}, Age - {Age}, Designation - {Designation}, CurrentAddress - ({CurrentAddress.Street},{CurrentAddress.City},{CurrentAddress.State}, {CurrentAddress.ZipCode}), PermanentAddress - ({PermanentAddress.Street},{PermanentAddress.City},{PermanentAddress.State}, {PermanentAddress.ZipCode}) ";
        }
    }

    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
