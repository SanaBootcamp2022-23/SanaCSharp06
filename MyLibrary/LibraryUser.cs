using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class LibraryUser : Person
    {
        //Variables
        protected string _readerNumber;
        protected DateTime _issueDate;
        protected double _contributionSize;

        //Properties
        public string ReaderNumber
        {
            get => _readerNumber;
            set => IsCorrectString(ref _readerNumber, value);
        }
        public DateTime IssueDate
        {
            get => _issueDate;
            set => _issueDate = value;
        }
        public double ContributionSize
        {
            get => _contributionSize;
            set => IsCorrectDobule(ref _contributionSize, value, 0, 1000);
        }

        //Constructors
        public LibraryUser()
        {
            _readerNumber = "None";
            _issueDate = DateTime.Now;
            _contributionSize = 0;
        }
        public LibraryUser(Person person)
            : base (person)
        {
            _readerNumber = "None";
            _issueDate = DateTime.Now;
            _contributionSize = 0;
        }
        public LibraryUser(Person person, string readerNumber, DateTime issueDate)
            : this (person)
        {
            ReaderNumber = readerNumber;
            IssueDate = issueDate;
        }
        public LibraryUser(Person person, string readerNumber, DateTime issueDate, double contributionSize)
            : this(person, readerNumber, issueDate)
        {
            ContributionSize = contributionSize;
        }
        public LibraryUser(LibraryUser libraryUser)
            : base (libraryUser._firstName, libraryUser._lastName, libraryUser._birthday)
        {
            _readerNumber = libraryUser._readerNumber;
            _issueDate = libraryUser._issueDate;
            _contributionSize = libraryUser._contributionSize;
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Basic methods
        public override string ToString()
        {
            string personString = base.ToString();

            return $"{personString}" +
                $"\nReader number: {_readerNumber}" +
                $"\nIssue date: {_issueDate}" +
                $"\nContribution size: {_contributionSize}";
        }

    }
}
