using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryUser : Human
    {
        private string readerNumber;
        private string receivingDate;
        private int tax;

        public LibraryUser(string name, string surname, DateTime dateOfBirth, string readerNumber) : base(name, surname, dateOfBirth) => SetReaderNumber(readerNumber);
        public LibraryUser(string name, string surname, DateTime dateOfBirth, string readerNumber, string receivingDate, int tax) : base(name, surname, dateOfBirth)
        {
            SetReaderNumber(readerNumber);
            SetReceivingDate(receivingDate);
            SetTax(tax);
        }

        public void SetReaderNumber(string value) => readerNumber = value;
        public string GetReaderNumber() => readerNumber;
        public void SetReceivingDate(string value) => receivingDate = value;
        public string GetReceivingDate() => receivingDate;
        public void SetTax(int value) => tax = value;
        public int GetTax() => tax;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {GetReaderNumber()}");
            Console.WriteLine($"Дата видачi: {GetReceivingDate()}");
            Console.WriteLine($"Розмiр щомiсячного читацького внеску: {GetTax()}");
        }
    }
}
