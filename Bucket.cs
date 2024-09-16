using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school1
{
    internal class Bucket : Container
    {
        public Bucket(int Capacity, int Content) : base(Capacity, Content)
        { 

        }
        public Bucket( int Content) : base(12, Content)
        {

        }
    }
}
