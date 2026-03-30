using System;

class Program
{
    // 1. Hàm đệ quy tính giai thừa
    static long GiaiThua(int n)
    {
        // Trường hợp cơ sở: 0! = 1 và 1! = 1
        if (n <= 1) return 1;

        // Bước đệ quy: n! = n * (n - 1)!
        return n * GiaiThua(n - 1);
    }

    // 2. Hàm đệ quy tính số Fibonacci thứ n
    static int Fibonacci(int n)
    {
        // Trường hợp cơ sở
        if (n == 0) return 0;
        if (n == 1) return 1;

        // Bước đệ quy: F(n) = F(n-1) + F(n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        // Nhập dữ liệu và chuyển đổi sang kiểu số nguyên
        int n = int.Parse(Console.ReadLine());

        // In kết quả Giai thừa
        Console.WriteLine("{0}! = {1}", n, GiaiThua(n));

        // In kết quả Fibonacci
        Console.WriteLine("Fibonacci({0}) = {1}", n, Fibonacci(n));

        // Dừng màn hình để xem kết quả
        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}