using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public sealed class One : BaseClass, IOne
    {
        private int[] array;

        public One(int cnt, bool way_to_fill = false) : base(way_to_fill)
        {
            array = new int[cnt];
            Fill();
        }
        

        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void RndmFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100000);
            }
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / array.Length);
        }

        public void no_repeat_elements()
        {
            int cnt = 1;
            for (int i = 1; i < array.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    cnt++;
                }
            }
            int[] changed_array = new int[cnt];
            int k = 1;
            changed_array[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    changed_array[k] = array[i];
                    k++;
                }
            }
            Console.Write("Массив, если удалить все дубликаты элементов: ");

            for (int i = 0; i < changed_array.Length; i++)
            {
                Console.Write(changed_array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
