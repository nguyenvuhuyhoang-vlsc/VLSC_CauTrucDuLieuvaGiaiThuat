using System;
using System.Diagnostics;
//Author: Nguyen Vu Huy Hoang - 2500113459
//Muc tieu: so sanh dieu nang giua Linear Search va Bnary Search tren mang sap xep voi 10 trieu phan tu



    class Program
    {
        static void Main()
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n = 10000000;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) arr[i] = i;
        int target = 9999999;
        Stopwatch sw = new Stopwatch();
        Console.WriteLine($"---------- thu nghiem voi {n} phan tu -----"); 

        //1. do thoi gian tim kiem va tuan tu
        sw.Start();
        int res1 = LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine($"[LinearSearch] Index: {res1}, time: {sw.Elapsed.TotalMilliseconds} ms");

        //2. Do thoi gian tim kiem nhi phan de quy (Recurive Binary Search)
        sw.Restart();
        int res2 = BinarySearchRecursive(arr,0,  n - 1, target);
        sw.Stop();
        Console.WriteLine($"[BinarySearchRecursive] Index: {res2}, time: {sw.Elapsed.TotalMilliseconds} ms");
        }
        //Cai dat tim kiem tuan tu - do phuc tap 0(n)
        static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

        //cai dat tim kiem nhi phan de quy - do phc tap 0(log n)
        static int BinarySearchRecursive(int[] arr, int left, int right, int x)
        {
            if (left > right) return -1;

            int mid = left + (right - left) / 2;

            if (arr[mid] > x)
            return BinarySearchRecursive(arr, left, mid - 1, x);
            return BinarySearchRecursive(arr, mid + 1, right, x);
        }
    }