using Microsoft.VisualBasic;
using System.Buffers;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace Advanced01
{
    class Program
    {
        //static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}
        static T FindMax<T>(T[] values) where T : IComparable<T>
        {
            T max = values[0];

            foreach (T value in values)
            {
                if (value.CompareTo(max) > 0)
                {
                    max = value;
                }
            }
            return max;
        }

        // Q7
        //static void Print<T>(T value) where T : struct    // value type
        //{
        //    Console.WriteLine(value);
        //}

        // Q8
        //static void Print<T>(T value) where T : class     // reference type
        //{
        //    Console.WriteLine(value);
        //}

        //Q10
        //class Student : IPrintabel
        //{
        //    public void Print()
        //    {
        //        Console.WriteLine("Student information");
        //    }
        //}
        //static void PrintItem<T>(T item) where T : IPrintabel
        //{
        //    item.Print();
        //}

        //Q12
        static T GetDefault<T>()
        {
            return default(T);
        }

        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?

            // A generic class is a class that can work with any data type.
            // Generics allow you to define a class with a placeholder for the data type.
            // This provides type safety, code reusability, and performance benefits.

            #endregion

            #region Q2: Write a generic class Container<T> with Add and Getmethods.
            //Container<int> intContainer = new Container<int>();
            //intContainer.Add(5);
            //Console.WriteLine(intContainer.Get()); // Output: 5

            //Container<string> stringContainer = new Container<string>();
            //stringContainer.Add("Hello");
            //Console.WriteLine(stringContainer.Get()); // Output: Hello, World!
            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            //A geniric class can have more than one type parameter

            //Pair<int, string> pair = new Pair<int, string>(1, "Ahmed");

            //pair.Print();
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            //A generic method is a method that can work with any data type.
            //int x= 15;
            //int y = 20;
            //Console.WriteLine($" Before Swap: x = {x}, y = {y}");
            //Swap<int>(ref x, ref y);
            //Console.WriteLine($" After Swap: x = {x}, y = {y}");
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value
            //int[] numbers = { 20, 60, 50, 70, 90, 80 };
            //int result = FindMax(numbers);
            //Console.WriteLine($"Maximum = {result}");

            #endregion

            #region Q6 What is a generic interface? Write IRepository<T>.
            // is an interface that uses type parameters, allowing it to work with different data types.
            // It defines a contract for classes that implement it, specifying methods and properties that must be provided.

            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            //The struct constraint restricts a generic type parameter to value types that are non  nullable

            //Print(10);
            //Print(5.5);
            //Print(true);
            #endregion

            #region Q8: What is the 'class' constraint? Write an example

            //The class constraint restricts a generic type parameter to reference types
            // Print("Hello");
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            // The new() constraint requires a generic type to have a public parameterless constructor,
            // allowing aninstance of that type to be created using new T().


            #endregion

            #region Q10: What is the interface constraint? Write an example.
            // An interface constraint restricts a generic type parameter to types that implement a specific interface.
            //لازم يكون Class أو Struct بيعمل Implement لـ Interface معين .

            //Student student = new Student();

            //PrintItem(student);
            #endregion

            #region Q11: What is the base class constraint? Write an example
            //The base class constraint in C# generics where T : BaseClass
            //means that the generic type T must inherit from or be the specified base class.

            //Test<Dog> test = new Test<Dog>();
            //test.Show(new Dog());

            #endregion

            #region Q12: How do you apply multiple constraints? Write an example.  
            //You can apply multiple constraints to a generic type by writing them after where T, separated by commas.

            #endregion

            #region  Q13: What does the 'default' keyword do in generics ?  
            //The default keyword in C# generics is used to obtain the default value of a type parameter.
           
            //int number = GetDefault<int>();
            //string text = GetDefault<string>();

            //Console.WriteLine(number); // 0
            //Console.WriteLine(text);   // null
            //#endregion
        }

    }

}