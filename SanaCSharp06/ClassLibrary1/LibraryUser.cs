using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryUser : Person
    {
        public int UserId { get; set; }
        public Date DateGive { get; set; }
        public LibraryUser() : base ()
        {
            UserId = 0;
            DateGive = new Date();
        }
        public LibraryUser(string name, string lastName, Date birthDate, int userId, Date dateGive) : base(name, lastName, birthDate)
        {
            UserId = userId;
            DateGive = dateGive;
        }
        public LibraryUser(string name, string lastName, Date birthDate, int userId) : base (name, lastName, birthDate)
        {
            UserId = userId;
            DateGive = new Date();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер відвідувача: {UserId}\n" +
                $"Дата видачи: {DateGive}");
        }
    }
}
