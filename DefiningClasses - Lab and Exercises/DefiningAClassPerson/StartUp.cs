using System;
namespace DefiningClasses
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();
			person1.Name = "Peter";
			person1.Age = 20;

			Person person2 = new Person
			{
				Name = "Ivan",
				Age = 37
			};

			Person person3 = new Person
			{
				Name = "Dimitrichko"
			};
			person3.Age = 24;
		}
	}
}