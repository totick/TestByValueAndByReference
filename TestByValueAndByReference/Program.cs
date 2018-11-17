using System;

namespace TestByValueAndByReference
{
    class Person
    {
        //Default value = 0
        public int age;
    }

    class MainClass
    {

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }

        public static void Main(string[] args)
        {
            int a = 10;
            int b = a; //Pass by Value
            b++;

            //a = 10, b = 11
            Console.WriteLine("a = {0}, b = {1}", a, b);

            int[] a1 = new int[3] { 1, 2, 3 };
            int[] a2 = a1; //Pass by Reference

            a2[0] = 5;
            a2[1] = 6;
            a2[2] = 7;

            //5 6 7
            for (int i = 0; i < a1.Length; i++){
                Console.Write(a1[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

            //5 6 7
            for (int i = 0; i < a2.Length; i++){
                Console.Write(a2[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

            int number = 1;
            Increment(number);

            //Incremented number: 1
            Console.WriteLine("Incremented number: {0}", number); //Pass by value

            var person = new Person();
            MakeOld(person);
            //Person age: 10
            Console.WriteLine("Person age: {0}", person.age); //Pass by reference
        }
    }
}
