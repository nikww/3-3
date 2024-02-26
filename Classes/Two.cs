using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public sealed class Two : BaseClass, ITwo
    {
        private int[,] array;
        private bool way_to_fill = false;

        public Two(int k, int l, bool way_to_fill = false) : base(way_to_fill)
        {
            array = new int[k,l];
            Fill();
        }

        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void RndmFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(100000);
                }

            }
        }

        public override void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / (array.GetLength(0) * array.GetLength(1)));
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void array_output_reversed()
        {
            Console.WriteLine("Вывод массива змейкой:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

