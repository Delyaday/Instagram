using Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSize
{
    class ReSize : IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;
        public Bitmap Apply(Bitmap Image)
        {
            int height = _oldImage.Height;
            int width = _oldImage.Width;



            return _newImage;
        }

        public Image Apply()
        {
            throw new NotImplementedException();
        }

        public Bitmap Cancel()
        {
            return _oldImage;
        }
    }
}
