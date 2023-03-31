namespace BingoPelc.Exceptions;

public class InvalidLoginDataException: Exception
{
    public string Email { get; set; }

    public InvalidLoginDataException(): base(nameof(InvalidLoginDataException))
    {
    }

    public InvalidLoginDataException(string email)
    {
        Email = email;
    }
}