using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BangunData
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar:
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");
            Console.WriteLine("5. Diamond");
            Console.WriteLine("Input Number : ");
            int choose = Convert.ToInt16(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("Input Side :");
                    var b = new Rectangle();
                    b.RectangleMth(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Area :" + b.area());
                    Console.WriteLine("Around :" + (4 * b.around()));
                    break;
                case 2:
                    Console.WriteLine("Input Longs :");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Wides :");
                    double l = Convert.ToDouble(Console.ReadLine());
                    var c = new Square();
                    c.SquareMth(p,l);
                    Console.WriteLine("Area :" + c.area());
                    Console.WriteLine("Around :" + c.around());
                    //int p = Convert.ToInt16(Console.ReadLine());
                    //Console.WriteLine("Input Wides :");
                    //int l = Convert.ToInt16(Console.ReadLine());
                    //Console.WriteLine("Area :" + (p * l));
                    //Console.WriteLine("Around :" + (2*(p+l)));
                    break;
                case 3:
                    Console.WriteLine("Input Radius :");
                    var a = new Circles();
                    a.CircleMth(Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Area :" + a.area());
                    Console.WriteLine("Around :" + a.around());
                    //Console.WriteLine("Area :" + (3.14 * (Math.Pow(rad, 2))));
                    //Console.Write("Around :" + (3.14 * (rad * 2)));
                    break;
                case 4:
                    Console.WriteLine("Input bases :");
                    int bases = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input heights :");
                    int heights = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Area :" + ((bases * heights)/2));
                    Console.Write("Around :" + (3 * bases));
                    break;
                case 5:
                    Console.WriteLine("Diagonale 1 :");
                    int d1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Diagonale 2 :");
                    int d2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(" :");
                    int sides = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Area :" + ((d1*d2)/2));
                    Console.Write("Around :" + (4 * sides));
                    break;
                default:
                    Console.WriteLine("Pilihan Tidak Sesuai");
                    break;
            }
            Console.WriteLine(" ");
            goto BangunDatar;
            }
    }

    
}
