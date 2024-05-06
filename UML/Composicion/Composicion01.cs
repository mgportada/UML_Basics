
namespace Composicion01
{
    using System;

    public class Head
    {
        public void Think()
        {
            Console.WriteLine("The person is thinking.");
        }
    }

    public class Arms
    {
        public void Wave()
        {
            Console.WriteLine("The person is waving their arms.");
        }
    }

    public class Legs
    {
        public void Walk()
        {
            Console.WriteLine("The person is walking.");
        }
    }

    public class Heart
    {
        public void Beat()
        {
            Console.WriteLine("The person's heart is beating.");
        }
    }

    public class Person
    {
        private Head head;
        private Arms arms;
        private Legs legs;
        private Heart heart;

        public Person()
        {
            head = new Head();
            arms = new Arms();
            legs = new Legs();
            heart = new Heart();
        }

        public void PerformActions()
        {
            head.Think();
            arms.Wave();
            legs.Walk();
            heart.Beat();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PerformActions(); // La persona realiza varias acciones utilizando sus partes del cuerpo
        }
    }

}
