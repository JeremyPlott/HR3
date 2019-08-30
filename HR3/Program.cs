using System;

namespace HR3 {
    class Program {
        static void Main(string[] args) {
            int[] arr = { 5, 10, 10, 50 }; 
            Array.Sort(arr);
            int indexCount = 0;
            long sum = 0;

            foreach(int index in arr) { //manual sum of array values
                sum += index;
            }

            //Console.WriteLine($"{sum}");

            //now manual check of highest index location
            foreach(int index in arr) {
                indexCount++;
            }

            //Console.WriteLine(indexCount);

            int highIndex = indexCount - 1;


            long arrMax = arr[highIndex];
            long arrMin = arr[0];

            long lowSum = sum - arrMax;
            long highSum = sum - arrMin;

            Console.Write($"{lowSum} {highSum}");
            //testing functions
            //foreach(int i in arr) {
            //    Console.Write(i + " ");
            //}

            //int highSum = arr.sum();
            //int lowSum = arr.sum();

            
        }
    }
}
