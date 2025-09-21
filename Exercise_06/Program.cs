using System.ComponentModel.Design;
using System.Text.RegularExpressions;

internal class exercise_6
{
    class Enter
    {
        public int ID;
        public int task;
        public string name = " ";
    }
    static void Main()
    {
        Console.WriteLine("EX01");
        Console.WriteLine("Bai 1. Tao mang.");
        arr();

        Console.Write("\nBai 2. Nhap so dong ban muon: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[rows][];
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"so cot cho dong thu {i + 1}: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            a[i] = new int[cols];
        }
        Console.WriteLine("\nMang moi la: ");
        ex01_2(a);

        Console.WriteLine("\nIn so lon nhat.");
        Max_row_array(a);

        Console.WriteLine("\nXep lai mang theo thu tu tang dan.");
        Sort(a);

        Console.WriteLine("\nIn so nguyen to.");
        Prime(a);

        Console.WriteLine("\nTim vi tri cua 1 so trong mang.");
        Console.Write("Nhap 1 so trong mang da cho:");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.Write($"Vi tri cua {num} la: ");
        Search(a,num);

        Console.WriteLine("EX02");
        Console.WriteLine("Nhap thong tin nhan vien cong ty.");
        Enter[] Group1 = new Enter[5];
        Enter[] Group2 = new Enter[3];
        Enter[] Group3 = new Enter[6];
        Console.WriteLine("Nhap thong tin 5 nguoi nhom 1.");
        Info(Group1, 5);
        Console.WriteLine("\nNhap thong tin 3 nguoi nhom 2.");
        Info(Group2, 3);
        Console.WriteLine("\nNhap thong tin 6 nguoi nhom 3.");
        Info(Group3, 6);

    }
    // Tạo mảng theo yêu cầu đề bài.
    static void arr()
    {
        int[][] a = new int[4][];
        a[0] = new int[5] { 1, 1, 1, 1, 1 };
        a[1] = new int[2] { 2, 2 };
        a[2] = new int[4] { 3, 3, 3, 3 };
        a[3] = new int[2] { 4, 4 };
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    //Tao mảng theo yêu cầu người dùng.
    static void ex01_2(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Random rnd = new Random();
                a[i][j] = rnd.Next(1, 100);
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    //Tìm số lớn nhất trong 1 hàng và 1 mảng.
    static void Max_row_array(int[][] a)
    {
        int max_array = a[0][0];
        for (int i = 0; i < a.Length; i++)
        {
            int max_row = a[i][0];
            for (int j = 1; j < a[i].Length; j++)
            {
                if (max_row < a[i][j])
                    max_row = a[i][j];
            }
            Console.WriteLine($"So lon nhat dong {i + 1} la: {max_row}");
            if (max_array<max_row)
                max_array = max_row;
        }
        Console.WriteLine($"So lon nhat mang la: {max_array}");
    }

    //Xếp các số trong từng hàng theo thứ tự từ bé đến lớn.
    static void Sort(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Array.Sort(a[i]);
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    //Tìm số nguyên tố trong mảng.
    static void Prime(int[][]a)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (a[i][j] < 2) continue;
                bool Isprime = true;
                for (int k = 2; k <= Math.Sqrt(a[i][j]); k++)
                {
                    if (a[i][j] % k == 0)
                    {
                        Isprime = false;
                        break;
                    }
                }
                if (Isprime)
                {
                    Console.Write(a[i][j] + " ");
                    count++;
                }
            }
        }
        if (count == 0)
            Console.WriteLine("Khong co so nguyen to.");
        else Console.WriteLine();
    }

    //Tìm vị trí của 1 số trong mảng.
    static void Search(int[][]a, int num)
    {
        int row = 0;
        int col = 0;
        bool found = false;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (num == a[i][j])
                {
                    row = i;
                    col = j;
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                break;
            }
        }
        Console.WriteLine($"dong {row+1}, cot {col+1}");
    }

    //Nhập thông tin nhân viên.
    static void Info(Enter[] group, int size)
    {
        for (int i = 0;i<size;i++)
        {
            group[i] = new Enter();
            Console.Write($"Nhap ID thanh vien thu {i+1}:");
            group[i].ID = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Nhap ho ten thanh vien thu {i + 1}:");
            group[i].name =Console.ReadLine();
            Console.Write($"Nhap so task thanh vien thu {i + 1} da hoan thanh:");
            group[i].task =Convert.ToInt32(Console.ReadLine());
        }
    }
}



