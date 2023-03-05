using System;
namespace Bff.Infrastructure.Exceptions;

public class BffCustomException : Exception
{
    public BffCustomException() : base()
    {

    }

    public BffCustomException(string message) : base(message)
    {
    }
}