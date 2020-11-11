using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Interface
{
    interface IFilter 
    {
        public Bitmap Apply(Bitmap Image);
        public Bitmap Cancel();
        Image Apply();
    }
}
