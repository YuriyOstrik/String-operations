using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, World!"; 
            string str2 = "hello, world!"; 
            string str3 = "Hello"; 
            // Сравнение с использованием метода Compare
            int compareResult = string.Compare(str1, str2, StringComparison.CurrentCulture); 
            Console.WriteLine($"Compare(\"{str1}\", \"{str2}\") = {compareResult}"); 
            // Сравнение с использованием метода Equals
            bool equalsResult = str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase); 
            Console.WriteLine($"Equals(\"{str1}\", \"{str2}\") = {equalsResult}"); 
            // Сравнение с использованием метода CompareOrdinal
            int compareOrdinalResult = string.CompareOrdinal(str1, str2);
            Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str2}\") = {compareOrdinalResult}"); 
            // Использование метода IndexOf
            int indexOfResult = str1.IndexOf("World");
            Console.WriteLine($"IndexOf(\"World\") in \"{str1}\" = {indexOfResult}");
            // Использование метода Contains
            bool containsResult = str1.Contains("World");
            Console.WriteLine($"Contains(\"World\") in \"{str1}\" = {containsResult}");
            // Сравнение с использованием операторов == и !=
            bool equalityOperatorResult = str1 == str3; 
            bool inequalityOperatorResult = str1 != str3; 
            Console.WriteLine($"\"{str1}\" == \"{str3}\" = {equalityOperatorResult}"); 
            Console.WriteLine($"\"{str1}\" != \"{str3}\" = {inequalityOperatorResult}");
        }
    }
}
