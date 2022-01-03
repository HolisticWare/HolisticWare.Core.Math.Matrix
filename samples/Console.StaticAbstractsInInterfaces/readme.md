# Readme


```
dotnet build Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj /v:diag
```

```
"/Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj" (default target) (1:7) ->
(CoreCompile target) -> 
    /Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Program.cs(7,14): error CS0315: The type 'int' cannot be used as type parameter 'T' in the generic type or method 'Sum<T>(IEnumerable<T>)'. There is no boxing conversion from 'int' to 'INumber<int>'. [/Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj]
    /Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Program.cs(13,16): error CS0119: 'T' is a type parameter, which is not valid in the given context [/Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj]
    /Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Program.cs(17,19): error CS0119: 'T' is a type parameter, which is not valid in the given context [/Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj]
    /Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Program.cs(11,15): error CS0246: The type or namespace name 'INumber<>' could not be found (are you missing a using directive or an assembly reference?) [/Users/Shared/Projects/d/hw-core/gh/261-HWC.Math.Matrix/samples/Console.StaticAbstractsInInterfaces/Console.StaticAbstractsInInterfaces.csproj]

    0 Warning(s)
    4 Error(s)

```


```
```

```
```
