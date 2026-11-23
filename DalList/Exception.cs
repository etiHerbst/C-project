

namespace Dal;

public class IdNotFoundException : Exception
{
    public IdNotFoundException(string message) : base(message) { }
    public IdNotFoundException(string message, Exception innerException) : base(message, innerException) { }

}

public class IdExistsException : Exception
{
    public IdExistsException(string message) : base(message) { }
    public IdExistsException(string message, Exception innerException) : base(message, innerException) { }

}

public class InvalidField : Exception
{
    public InvalidField(string message) : base(message) { }
    public InvalidField(string message, Exception innerException) : base(message, innerException) { }

}
