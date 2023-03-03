using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibUser:Human
    {
       private int _id;
       private DateOnly _regDay;
       private int _readFee;

        public int Id { get { return _id; } set { _id = value; } }

        public DateOnly RegDay { get { return _regDay;} set { _regDay = value; } }
        public int ReadFee { get { return _readFee;} set { _readFee = value; } }

        public LibUser(int id,DateOnly regDay, int readFee) {
            Id = id;
            RegDay = regDay;
            ReadFee = readFee;
        
        }
        public LibUser(LibUser Copy)
        {
            Id = Copy.Id;
            RegDay = Copy.RegDay;
            ReadFee = Copy.ReadFee;

        }
        public LibUser(string name, string surname, DateOnly dateOfBirth,
            int id, DateOnly regDay, int readFee) : base(name, surname, dateOfBirth)
        {
            Id = id;
            RegDay = regDay;
            ReadFee = readFee;

        }
        public LibUser(Human human, int id, DateOnly regDay, int readFee) :base(human)
        {
            Id = id;
            RegDay = regDay;
            ReadFee = readFee;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\n Name: {Name}\n Surname: {Surname}\n Date of birth: {DateOfBirth}\n Register day: {RegDay}\n Fee:{ReadFee}\n");
        }

    }
}
