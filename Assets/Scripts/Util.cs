
using System;

public class Util
{
    public static long GetCurrentTimestamp()
    {
        return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }    
}