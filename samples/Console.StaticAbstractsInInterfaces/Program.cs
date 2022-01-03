// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

int result = Sum(new[] { 1, 2, 3 });
Console.WriteLine(result);

static T Sum<T>(IEnumerable<T> values)
    where T : INumber<T>
{
    T result = T.Zero;

    foreach (var value in values)
    {
        result += T.Create(value);
    }

    return result;
}
