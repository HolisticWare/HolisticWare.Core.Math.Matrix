# HolisticWare.Core.Math.Matrix

Matrix operations and algebra

`Core.Math.Matrixes`

*   naming

    *   `Matrixes` (modern English) instead of `Matrices` (latin derived)

*   implementations

    *   Array  `T[]`

        *   IEnumerable  `IEnumerable<T>`

        Arrays do implement IEnumerable<T>, but it is done as part of the special knowledge the CLI has for arrays. This works as if it were an explicit implementation (but isn't: it is done at runtime). Many tools will not show this implementation, this is described in the Remarks section of the Array class overview.
    
        https://docs.microsoft.com/en-gb/dotnet/api/system.array?view=netframework-4.7#remarks
        
    *   Memory  `Memory<T>`

        *   https://docs.microsoft.com/en-us/dotnet/api/system.memory-1?view=net-6.0

## TODOs

*   @todo: `ToString()` as valid C#

### Generic Math

*   https://github.com/HelloKitty/Generic.Math

*   https://devblogs.microsoft.com/dotnet/preview-features-in-net-6-generic-math/

*   https://dunnhq.com/posts/2021/generic-math/

*   libraries

    *   https://github.com/samtrion/netevolve-guard/tree/main/src/NetEvolve.Guard.Experimental
    


*   http://core.loyc.net/math/maths

*   https://www.extremeoptimization.com/Documentation/Mathematics/Generic-Arithmetic/Using-Generic-Arithmetic.aspx

*   https://jonskeet.uk/csharp/miscutil/usage/genericoperators.html

*   https://stackoverflow.com/questions/30580567/how-to-perform-math-operations-with-generic-variables

*   http://www.shujaat.net/2012/05/c-generics-arithmetic-operators.html

### GPU

*   ComputeSharp

    *   https://github.com/SingleAccretion/ComputeSharp

    *   DirectX

*   Hybridizer

    *   https://developer.nvidia.com/blog/hybridizer-csharp/

*   ILGPU

    *   https://www.ilgpu.net/

    *   https://github.com/m4rs-mt/ILGPU/

    *   https://github.com/m4rs-mt/ILGPU/tree/master/Samples

*   Alea GPU

    *   https://learn.microsoft.com/en-us/shows/seth-juarez/radically-simplified-gpu-programming-c

*   https://stackoverflow.com/questions/375011/utilizing-the-gpu-with-c-sharp

*   https://stackoverflow.com/questions/4119876/run-c-sharp-code-on-gpu

https://stackoverflow.com/questions/46392132/c-sharp-opencl-gpu-implementation-for-double-array-math

https://stackoverflow.com/questions/1249892/c-perform-operations-on-gpu-not-cpu-calculate-pi

https://stackoverflow.com/questions/51455603/process-a-heavy-function-by-gpu-in-c-sharp

## DONE


## WIP (Work in Progress)

### Terms/definitions

*   types

    *   Scalar

    *   Vector
        -   Row vectors
        -   Column vectors

    *   Matrix
        -   Matrix size
        -   Submatrix
        -   Square matrix
        -   Triangular matrix
        -   Diagonal matrix
        -   Scalar matrix
        -   Identity matrix
        -   Symmetric matrix
        -   Inverse matrix

*   Conversion Operators
    
*   Algebra

    *   `operator+`
    
        ```
        Vector<int> result_01 = va + vb;
        Matrix<int> result_01 = ma + mb;
        ```

    *   `operator-`

        ```
        Vector<int> result_01 = va - vb;
        Matrix<int> result_01 = ma - mb;
        ```
        
    *   `operator*`

        ```
        Vector<int> result_01 = va * vb;
        Matrix<int> result_01 = ma * mb;
        ```
        
    *   `operator/` ??

        ```
        Vector<int> result_01 = va / vb;
        Matrix<int> result_01 = ma / mb;    // m * 1/mb = m * mb.Inverse();

    *   `Matrix-Scalar Operations`

    *   `Matrix-Vector Multiplication`

    *   `Matrix-Matrix Multiplication`

    *   `Inverse`

    *   `Transposition`

    *   `Trace`

    *   `Determinant`

    *   `Vector norm`

    *   `Normalized vector`

    *   `Euclidean distance`




        
## Work in Progress

*   Constructors

    *   Initializers
    
*   `ToString()`


## DONE

## Links / References

*   samples

    *   https://www.mathsisfun.com/algebra/matrix-introduction.html
    
    *   https://www.wolframalpha.com/examples/mathematics/algebra/matrices/
    
    *   https://www.analyzemath.com/linear-algebra/matrices/matrices-examples-and-questions-with-solutions.html
    
    *   http://www.maths.surrey.ac.uk/explore/emmaspages/option1.html
    
    *   https://www.statisticshowto.com/matrices-and-matrix-algebra/
    
    *   https://www.intmath.com/matrices-determinants/matrix-multiplication-examples.php
    
    *   https://www.onlinemathlearning.com/matrices-types.html
    
    *   https://www.studypug.com/algebra-help/notation-of-matrices
    
    *   https://brilliant.org/wiki/matrices/
    
    *   https://www.ixl.com/math/algebra-2/multiply-two-matrices
    
*   theory

    *   https://en.wikipedia.org/wiki/Euclidean_vector

    *   https://en.wikipedia.org/wiki/Vector_algebra

    *   https://en.wikipedia.org/wiki/Matrix_(mathematics)

    *   https://en.wikipedia.org/wiki/Tensor

*   https://www.extremeoptimization.com/Documentation/Default.asp

*   System.Numerics

    *   Proposal for more System.Numerics APIs #35980
    
        *   https://github.com/dotnet/runtime/issues/35980

    *   Add Matrix3x3 #16226

        *   https://github.com/dotnet/runtime/issues/16226
