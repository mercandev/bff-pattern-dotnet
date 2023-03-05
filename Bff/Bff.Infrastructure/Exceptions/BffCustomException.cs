using System;
namespace Bff.Infrastructure.Exceptions;

[Serializable]
public class BffCustomException : Exception
{
    public BffCustomException() : base()
    {

    }

    public BffCustomException(string message) : base(message)
    {
    }
}