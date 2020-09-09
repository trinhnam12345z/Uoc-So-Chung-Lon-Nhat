using System;

namespace TimUocChungLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1, n2;
            Console.Write("\n");
            Console.Write("CT Tim uoc so chung lon nhat trong :\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            timUCLN(n1, n2);
            Console.ReadKey();
        }
        static void timUCLN(int n1, int n2)
        {
            int i, j, uscln = 1;
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    uscln = i;
                }
            }
            Console.Write("\nUSCLN cua {0} va {1} la: {2}\n\n", n1, n2, uscln);
        }
    }
}
