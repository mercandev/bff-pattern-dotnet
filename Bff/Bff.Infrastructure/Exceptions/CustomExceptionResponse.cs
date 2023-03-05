using System;
using Newtonsoft.Json;
using System.Net;

namespace Bff.Infrastructure.Exceptions;


[Serializable]
public class CustomExceptionResponse
{
    public string ErrorMessage { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}