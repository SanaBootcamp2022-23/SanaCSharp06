using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp6
{
    public class UserOfLibrary:Person
    {
        public string CardNumber { get; set; }
        public string DateOfIssue { get; set; } 
        public string cost { get; set; }

        public UserOfLibrary(string name, string surname, string birth ,string cardNumber,string dateOfIssue,string monthlyReadershipFee):base(name, surname, birth)
        {
            CardNumber = cardNumber;
            cost = monthlyReadershipFee;
            DateOfIssue= dateOfIssue;
        }
        public UserOfLibrary(string name, string surname, string birth, string cardNumber, string monthlyReadershipFee) : base(name, surname, birth)
        {
            CardNumber = cardNumber;
            cost = monthlyReadershipFee;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Номер читацького квитка: {CardNumber};\nРозмір щомісячного читацького внеску: {cost} гривень";
            info += DateOfIssue == "" ? "" : $"\nДата видачі: {DateOfIssue};";
            Console.WriteLine(info);
        }
    }
}
