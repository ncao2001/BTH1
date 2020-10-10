using System;
namespace Bài_TH1
{
    class MaTran
    {
        private int m, n;
        private int[,] a;
        public MaTran()
        {
            m = n = 2;
            a = new int[m, n];
        }
        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }
        public MaTran(MaTran t2)
        {
            this.m = t2.m;
            this.n = t2.n;
            this.a = new int[m, n];
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    this.a[i, j] = t2.a[i, j];
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public void Hien()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public MaTran Tong(MaTran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                MaTran t = new MaTran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
        public MaTran Hieu(MaTran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                MaTran t = new MaTran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] - t2.a[i, j];
                return t;
            }
            else return null;
        }
    }
    class App
    {
        static void Main5()
        {
            Console.WriteLine("Nhap thong tin cho ma tran thu nhat");
            MaTran t1 = new MaTran(2, 3);
            t1.Nhap();
            Console.WriteLine("Nhap thong tin cho ma tran thu hai");
            MaTran t2 = new MaTran(t1);
            t2.Nhap();
            MaTran t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Hai ma tran co kich thuoc khac nhau, ko tinh tong dc");
            else
            {
                Console.WriteLine(" Thong tin cua ma tran tong");
                t3.Hien();
            }
            MaTran t4 = t1.Hieu(t2);
            if (t4 == null)
                Console.WriteLine("Hai ma tran co kich thuoc khac nhau, ko tinh hieu dc");
            else
            {
                Console.WriteLine(" Thong tin cua ma tran hieu");
                t4.Hien();
            }
            Console.ReadKey();
        }
    }
}