using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_Console
{
    public class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public double EngineSize { get; set; }
        public virtual Owner owner { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Vendor}, {Model}, {HorsePower}, {EngineSize}  " +
                   $" \nOwner {owner.Id} : {owner.first_name}, {owner.Last_name}, {owner.Age}";
        }
    }
}
