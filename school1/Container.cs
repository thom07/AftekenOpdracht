using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    internal abstract class Container
    {
        public int Capacity { get; }

        public int Content { get; set; }

        public Container(int Capacity, int Content) 
        {
            if (Capacity <= 0)
            {
            }
            else { this.Capacity = Capacity; }
        }
        public void Fill(int ammount)
        {

        }

        public void Empty(int ammount)
        {

        }

        public void EmptyFully()
        {
            Content = 0;
        }
    }
}
