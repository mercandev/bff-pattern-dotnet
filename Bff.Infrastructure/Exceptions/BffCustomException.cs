using System;
using System.Runtime.Serialization;

namespace Bff.Infrastructure.Exceptions;

public class BffCustomException : Exception , ISerializable
{
    protected BffCustomException() : base()
    {

    }

    public BffCustomException(string message) : base(message)
    {
    }
}