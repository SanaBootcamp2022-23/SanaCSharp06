namespace OOP2Library.Exceptions
{
    public class EIATestDuplicateException : Exception
    {
        public EIATestDuplicateException(string message
            = "Неможливо додати декілька однакових предметів!")
            : base(message) { }
    }

    public class EIATestNotFoundException : Exception
    {
        public EIATestNotFoundException(string message
            = "Вказаний предмет не знайдено!")
            : base(message) { }
    }
}
