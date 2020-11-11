using Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadesOfGray 

{
    
     class ShadesOfGray : IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;


        public Bitmap Apply(Bitmap Image)
        {
            Color pixel; //RGB(0, 255)
            int height = _oldImage.Height;
            int width = _oldImage.Width;

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = _oldImage.GetPixel(w, h);
                    pixel = Color.FromArgb(pixel.R, pixel.G, pixel.R);
                    _newImage.SetPixel(w, h, pixel);
                }
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
