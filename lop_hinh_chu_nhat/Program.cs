using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop_hinh_chu_nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lop_chu_nhat H1 = new lop_chu_nhat(5, 2);
            H1.xuat();
            Console.ReadLine();
        }
    }
}
