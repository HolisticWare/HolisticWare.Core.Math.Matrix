# HolisticWare.Core.Math.Matrix
Matrix operations and algebra

## TODOs

*   @todo: `ToString()` as valid C#

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

*   https://en.wikipedia.org/wiki/Euclidean_vector

*   https://en.wikipedia.org/wiki/Vector_algebra

*   https://en.wikipedia.org/wiki/Matrix_(mathematics)

*   https://en.wikipedia.org/wiki/Tensor

*   https://towardsdatascience.com/linear-algebra-for-deep-learning-f21d7e7d7f23

*   https://en.wikipedia.org/wiki/Matrix_(mathematics)

**https://www.extremeoptimization.com/Documentation/Default.asp**