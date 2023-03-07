using System;

namespace ClassLibrary
{
    public class Abitur : Person
    {
        protected int scoreZNO { get; set; }
        protected int scoreAtest { get; set; }
        protected string nameZNZ { get; set; }

        public Abitur(string firstName, string lastName, int scoreZNO, int scoreAtest, string nameZNZ) : base(firstName, lastName)
        {
            this.scoreZNO = scoreZNO;
            this.scoreAtest = scoreAtest;
            this.nameZNZ = nameZNZ;
        }
        public Abitur(string firstName, string lastName, string nameZNZ) : base(firstName, lastName)
        {

            this.nameZNZ = nameZNZ;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($" Name: {this.firstName}");
            Console.WriteLine($" Surname: {this.lastName}");
            Console.WriteLine($" ZNO scores: {this.scoreZNO}");
            Console.WriteLine($" Atestation scores: {this.scoreAtest}");
            Console.WriteLine($" Study placement: {this.nameZNZ}");
            Console.WriteLine("----------------------------------");
        }
    }
}