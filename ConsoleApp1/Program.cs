using ConsoleApp1;
using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 3, 5 };
            //Array.Resize(ref array, array.Length+1);
            //array[array.Length - 1] = 4;
            //MyintList myintlist = new MyintList();
            //myintlist.AddItem(7);
            //myintlist.AddItem(8);
            //myintlist.AddItem(9);
            //MystringList mystringlist = new MystringList();
            //mystringlist.AddItem("test1");
            //mystringlist.AddItem("test2");
            //mystringlist.AddItem("test3");
            //mystringlist.ShovItem();
            //MyPersonList mypersonlist = new MyPersonList();
          ;
            MyList<Person> person = new MyList<Person>();
            person.AddItem(new Person { Name = "ceyran1", SurName = "sultanova", Age = 23 });
            person.AddItem(new Person { Name = "ceyran2", SurName = "sultanova", Age = 25 });
            person.ShovItem();
            MyList<> person = new MyList<Person>();
            person.AddItem(new Person { Name = "ceyran1", SurName = "sultanova", Age = 23 });
            person.AddItem(new Person { Name = "ceyran2", SurName = "sultanova", Age = 25 });
            person.ShovItem();

        }

    }
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[0];
        }
        public void AddItem(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;


        }
        public void ShovItem()
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    class MyPersonList
    {
        private Person [] array;
        public MyPersonList()
        {
            array = new Person [0];
        }
        public void AddItem(Person item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;


        }
        public void ShovItem()
        {
            foreach (Person item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
    //class MyList <T>
    //{

    //}
}
