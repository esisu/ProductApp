namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation Error occured")
        {
        }

        public ValidationException(string message) : base(message) { }

        ValidationException(Exception ex) : this(ex.Message) { }

    }
}
