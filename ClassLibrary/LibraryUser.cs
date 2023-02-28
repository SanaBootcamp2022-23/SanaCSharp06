using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Human
    {
        private int kvutokNumber;
        private DateTime dataVudachi;
        private double rozmirVnesky;

        public int KvutokNumber { get => kvutokNumber; set => kvutokNumber = value; }
        public DateTime DataVudachi { get => dataVudachi; set => dataVudachi = value; }
        public double RozmirVnesky { get => rozmirVnesky; set => rozmirVnesky = value; }

        public LibraryUser() { }


        public LibraryUser(string name, string surName, DateTime dateOfBirth, int kvutoknumber, DateTime datavudachi, double rozmirVnesky) : base(name, surName, dateOfBirth)
        {
            KvutokNumber = kvutoknumber;
            DataVudachi = datavudachi;
            RozmirVnesky = rozmirVnesky;
        }

        public LibraryUser(LibraryUser copyLibraryUser)
        {
            Name = copyLibraryUser.Name;
            SurName = copyLibraryUser.SurName;
            DateOfBirth = copyLibraryUser.DateOfBirth;
            KvutokNumber = copyLibraryUser.KvutokNumber;
            DataVudachi = copyLibraryUser.DataVudachi;
            RozmirVnesky = copyLibraryUser.RozmirVnesky;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Інформація про користувача бібліотеки:\nНомер читацького квитка:{KvutokNumber}\t Дата видачі:{DataVudachi.ToString("dd/MM/yyyy")}\t Розмір щомісячного читацького внеску:{RozmirVnesky} гривень");
        }

    }
}
