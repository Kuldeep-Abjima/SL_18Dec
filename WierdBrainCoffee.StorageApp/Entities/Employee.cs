using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdBrainCoffee.StorageApp.Entities
{
    public class Employee : EntityBase
    { 
        public string FirstName { get; set; }

        public override string ToString() => $"Id: {Id},FirstName: {FirstName}";

    }
}
