using System;
using System.Linq;
using System.Collections.Generic;

public static class EvenNumbersExtensions
{
    public static List<int> evenNumber(this List<int> numbers)
    {
        return numbers.Where(n => n %2 ==0).ToList();
    }
}