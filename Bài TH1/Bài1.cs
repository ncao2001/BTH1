using System;
using System.Text;
namespace Bài_TH1
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhập x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
        public double KhoangCach()
        {
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }
    }
    class APP
    {
        static void Main1(string[] args)
        {

        }
    }
}