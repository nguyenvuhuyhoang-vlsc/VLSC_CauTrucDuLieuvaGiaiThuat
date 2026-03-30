using System;

    // Author: Nguyen Vu Huy Hoang - 2500113459
    // Muc tieu: Hoc cach su dung cac thuat toan sap xep co ban

    class Program {
        static void Main() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Nhap cac phan tu:");
            for (int i = 0; i < n; i++)  
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] arrBubble = (int[])arr.Clone();
            int[] arrInsertion = (int[])arr.Clone();

            // Bubble Sort
            BubbleSort(arrBubble);
            Console.WriteLine("Mang sau khi sap xep bang Bubble Sort:");
            PrintArray(arrBubble);

            // Insertion Sort
            InsertionSort(arrInsertion);
            Console.WriteLine("Mang sau khi sap xep bang Insertion Sort:");
            PrintArray(arrInsertion);

        static void BubbleSort(int[] arr) {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++) 
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] arr) {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr) {
            foreach (int num in arr) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}