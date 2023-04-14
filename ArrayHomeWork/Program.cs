using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[10];
            Number[0] = 10;
            Number[1] = 4;
            Number[2] = 6;
            Number[3] = 7;
            Number[4] = 8;
            Console.Write("Input New Value: ");
            int NewValue = Int32.Parse(Console.ReadLine());
            Console.Write("Input Index for New Number: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x < 0 || x >= Number.GetLength(0)-1)
            {
                Console.WriteLine("Invalid Index");
            }
            int[] NewNumber = new int[10];
            for (int i = 0; i < NewNumber.Length; i++)
            {
                if (i == x)
                {
                    NewNumber[i] = NewValue;
                }
                else if (i < x)
                {
                    NewNumber[i] = Number[i];
                }
                else if (i > x && i < NewNumber.Length)
                {
                    NewNumber[i] = Number[i - 1];
                }
                else { continue; }
                
                Console.WriteLine($"Index [{i}]: \n Old = {Number[i]} - New = {NewNumber[i]}");
            }
        }
    }
}
