using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public abstract class ObtainableItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int MaximumStackableQuantity { get; set; }
        protected ObtainableItem()
        {
            ID = new Guid();
            MaximumStackableQuantity = 1;
        }
    }
}
