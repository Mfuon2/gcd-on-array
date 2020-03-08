using System;

namespace GcdOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 6, 12, 16 }; 
            var n = arr.Length; 
            Console.Write(FindGcd(arr, n)); 
        }
        
        static int GetGcd(int valueOne, int valueTwo)
        {
            return valueOne == 0 ? valueTwo : GetGcd(valueTwo % valueOne, valueOne);
        }

        private static int FindGcd(int[] arr, int arrSize) 
        { 
            var answer = arr[0]; 
            for (var i = 1; i < arrSize; i++){ 
                answer = GetGcd(arr[i], answer); 
                if(answer == 1) 
                { 
                    return 1; 
                } 
            } 
            return answer; 
        } 
        
        
    }
}