using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        private int numberLibraryCard = 1;
        private string dateIssueBook = "01.01.2023";
        private float moneyDepositInMonth = 0;
        public int NumberLibraryCard { get => numberLibraryCard;
            set
            {
                if (value > 0)
                    numberLibraryCard = value;
            }
        }
        public string DateIssueBook { get => dateIssueBook;
            set
            {
                if (value.Length >= 6)
                    dateIssueBook = value;
            }
        }
        public float MoneyDepositInMonth { get => moneyDepositInMonth;
            set
            {
                if (value > 0)
                    moneyDepositInMonth = value;
            }
        }

        public LibraryUser(string FirstName, string LastName, string DateOfBirth, int NumberLibraryCard, string DateIssueBook, float MoneyDepositInMonth)
            :base(FirstName, LastName, DateOfBirth)
        {
            this.NumberLibraryCard = NumberLibraryCard;
            this.DateIssueBook = DateIssueBook;
            this.MoneyDepositInMonth = MoneyDepositInMonth;
        }
        public LibraryUser(string FirstName, string LastName, int NumberLibraryCard, string DateIssueBook)
            : base(FirstName, LastName)
        {
            this.NumberLibraryCard = NumberLibraryCard;
            this.DateIssueBook = DateIssueBook;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} \nНомер читацького квитка: {NumberLibraryCard} \nДата видачі: {DateIssueBook} " +
                $"\nРозмір щомісячного читацького внеску: {MoneyDepositInMonth}";
        }
    }
}
