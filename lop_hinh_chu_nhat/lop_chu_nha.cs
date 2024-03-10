using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lop_hinh_chu_nhat
{
    internal class lop_chu_nhat
    {
       
            double width, height;

        public lop_chu_nhat(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; set => width = value; }
            public double Height { get => height; set => height = value; }
        public void xuat()
            {
                double dientich = Width * Height;
                double chuvi = 2 * (Width + Height);
                Console.Write($"dien tich la: {dientich}, chu vi la: {chuvi}");
            }
        }
}
