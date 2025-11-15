using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Shared;
public class ApiResponse<T>
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    public IEnumerable<string>? Errors { get; set; }

    private ApiResponse(bool success,string message,T? data=default,IEnumerable<string>? errors=default)
    {
        IsSuccess = success;
        Message = message;
        Data = data;
        Errors = errors;
    }
    public static ApiResponse<T> Success(string message,T? data=default)
    {
        return new ApiResponse<T>(true, message, data);
    }
    public static ApiResponse<T> Fail(string message,IEnumerable<string>? errors=default)
    {
        return new ApiResponse<T>(false, message, default, errors);
    }
}
