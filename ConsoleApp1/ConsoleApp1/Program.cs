namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { }
            public readonly record struct Result<T>(bool IsSuccess,T? Value, Error? Error)
        {
            public static Result<T> Ok(T value) => new(true, value, null);

            public static Result<T> Fail(Error error) => new(false, default, error);
        }
        public abstract record Error(string Code, string Message)
        {
            public sealed record NotFound( string EntityName, Guid Id) : Error("NotFound",$"{EntityName} with ID {Id} was not found");

            public sealed record Validation(string Message): Error("ValidationError", Message);
        }

    }
}
