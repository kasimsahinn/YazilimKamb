using System;

namespace DENEME
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("Karabük");
            sehirler2.Add("Bartın");
            sehirler2.Add("Erzurum");
            sehirler2.Add("Sinop");
            sehirler2.Add("Kastamonu");
            sehirler2.Add("Ordu");

            Console.WriteLine(sehirler2.Count);


        }
    }
    class MyList<T>
    {
        T[] array;
        T[] tempArray;
        
        public MyList()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;
        }

        public int Count
        {
            get { return array.Length; } 
        }

    }
}
