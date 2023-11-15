using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Money : ObtainableItem
    {
        public Money()
        {
            Name = "Money";
            MaximumStackableQuantity = 10000;
        }
    }
}
