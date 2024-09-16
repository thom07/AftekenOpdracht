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
            
            if (Content < 0)
            {
                throw new ArgumentException("Content cannot be negative.");
            }

            if (Content > Capacity)
            {
                throw new ArgumentException("Content cannot be bigger then capacity.");
            }

            this.Capacity = Capacity;
            this.Content = Content;
        }
        public void Fill(int ammount)
        {
                Content += ammount;
        }

        public void Empty(int ammount)
        {
            Content -= ammount;
        }

        public void EmptyFully()
        {
            Content = 0;
        }
        public void ContainerInfo()
        {
            Console.WriteLine($"The Capacity is: {Capacity} and the Content is: { Content }");
        }
    }
}
