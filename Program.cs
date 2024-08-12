using System;

namespace SUDUNGCAULENHLAP
{
    class TimUocChungLonNhat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap hai so can tim uoc chung lon nhat:");
            int a = Math.Abs(int.Parse(Console.ReadLine()));
            int b = Math.Abs(int.Parse(Console.ReadLine()));

            if (a == 0 && b == 0)
            {
              Console.WriteLine("Khong tim duoc uoc chung lon nhat");
            }
            else if (a==0&&b!=0)
            {
              Console.WriteLine("Uoc chung lon nhat bang: "+b);
            }
            else if (b==0&&a!=0)
            {
              Console.WriteLine("Uoc chung lon nhat bang: "+a);
            }
            else
            {
              while (a != b)
                {
                    if (a > b)
                    {
                      a = a - b;
                    }
                    else
                    {
                      b = b - a;
                    }
                }
              Console.WriteLine("Uoc chung lon nhat bang: " + a);
            }
      }
  }
}