# ApiJsonError

This is a small library to provide you with something similar to the `abort` function in Bottle or Flask (Python). 

# Why ?

Returing a HTTP error in C# Web Api is a bit tedious and takes multiple lines. 

First you have to create a `HttpResponseMessage`, populate it and throw an `HttpResponseException`. 

```c#
var response = new HttpResponseMessage((HttpStatusCode)401)
{
    Content = "ApiKey invalid"
}
throw new HttpResponseException(response);
```

It's even more tedious if you want to return a JSon string as your error.

```c#

var response = new HttpResponseMessage((HttpStatusCode)401)
{
    Content = new StringContent(JsonConvert.SerializeObject(new {
        status_code = 401,
        message = "ApiKey invalid"
    }))
}
throw new HttpResponseException(response);
```

For those familar with e.g. Python and Bottle, this seems overly verbose in comparasion with this python example:

```python
abort(401, "ApiKey invalid")
```

# Usage

```c#

using ApiJsonError

// You can either throw an exception
throw new ApiException(401, "ApiKey invalid");

// or call the abort method

ApiJsonError.abort(401, "ApiKey invalid");a
```