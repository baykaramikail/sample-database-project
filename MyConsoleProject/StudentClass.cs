using NSpace;


namespace MyConsoleProject
{

	interface Asa
	{
		void doSomething();
	}

    public struct Mines
	{
		public string car { get; set; }
	}


	public class Student: Person
	{
		protected int money;

		public int Age { get; set; }

		public string Mail { get; set; }

		public Mines[]? mines;



		public Student(string name, int age, string mail): base(name)
		{
			Name = name;
			Age = age;
			Mail = mail;
			mines = new Mines[] { new Mines() };
		}

	}


    class Studente : Student
    {
        public Studente(string name, int age, string mail) : base(name, age, mail)
        {
			money = 23;
        }
    }


}


