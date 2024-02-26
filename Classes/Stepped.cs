using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public sealed class Stepped : BaseClass, IStepped
    {
        private int[][] array;
        private bool way_to_fill = false;

        public Stepped(int k, bool way_to_fill) : base(way_to_fill)
        {
            array = new int[k][];
            Fill();
        }

        protected override void RndmFill()
        {   
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Random rnd = new Random();
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = rnd.Next(10000);
                }
            }
        }

        protected override void FillByUser()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Console.WriteLine("Введите элементы строки массива:");
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void mid_value()
        {
            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    cnt++;
                }
            }
            Console.WriteLine("Среднее значение во всём массиве: " + sum / cnt);
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void change_odd()
        {
            int[][] new_array = array;
            for (int i = 0; i < new_array.Length; i++)
            {
                for (int j = 0; j < new_array[i].Length; j++)
                {
                    if (new_array[i][j] % 2 == 0)
                    {
                        new_array[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Массив после изменения:");

            for (int i = 0; i < new_array.Length; i++)
            {
                for (int j = 0; j < new_array[i].Length; j++)
                {
                    Console.Write(new_array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

