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
                throw new ArgumentException("Capacity cannot be negative.");
            }
            else { this.Capacity = Capacity; }
            if (Content <= 0)
            {
                throw new ArgumentException("Content cannot be negative.");
            }
            else { this.Content = Content; }
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
