using System;
using MyConsoleProject;



namespace NSpace
{
    class Program
    {

        public static void Main(string[] args)
        {

            //Studente student = new Studente("mikail", 23, "mikail@")
            //PrintGiven(student.Age);


            Matematik matematik = new Matematik();

            Console.WriteLine(matematik.Bol(23,0));
           

        }

        static void PrintNames(Person person)
        {
            Console.WriteLine(person.Name);
        }



        static string PrintGiven<T>(T thing)
        {
            Console.WriteLine(thing);

            return $"{thing}";
        }


        
    }



    interface IPersonManager
    {

        void Add();
    }

    public class Person: IPersonManager
    {
        public string Name { get; set; }

        public virtual void Add()
        {
            Console.WriteLine("hi this is Person class");

        }

        public Person(string name)
        {
            Name = name;

        }

    }


    class Customer : Person, IPersonManager
    {
        public Customer(string name) : base(name)
        {
        }

        public int customerID { get; set; }


        public void AddCustomer()
        {

        }

        public override void Add()
        {
            Console.WriteLine("hi this is customer class");
        }
    }

    

    class Matematik
    {

        public decimal Bol(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
           
        }

    }

}

