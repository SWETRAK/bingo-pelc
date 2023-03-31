namespace BingoPelc.Exceptions;

public class UserNotFoundException: Exception
{
    public string GuidString { get; set; }

    public UserNotFoundException(): base(nameof(UserNotFoundException))
    {
    }

    public UserNotFoundException(string guidString): base(nameof(UserNotFoundException))
    {
        GuidString = guidString;
    }
}