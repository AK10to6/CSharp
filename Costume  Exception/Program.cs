using System;
using System.Runtime.Serialization;

public class CustomExc {
    public static void Main()
    {
        try {
            throw new UserAlreadyLoggedException("User is already Logged in");
        }
        catch (UserAlreadyLoggedException ex) { 
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedException : Exception   //Costome Exception Defined
{
    public UserAlreadyLoggedException() : base() { }
    public UserAlreadyLoggedException(string message) : base(message) { }
    public UserAlreadyLoggedException(string message, Exception innerException) : base(message, innerException) { }
    public UserAlreadyLoggedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}