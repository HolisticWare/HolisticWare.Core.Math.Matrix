// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestContext = HolisticWare.Core.Testing.UnitTests.TestContext;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Collections.ObjectModel;

using Core.Math.MatrixTheory.Generics;

namespace UnitTests.Core.Math.MatrixTheory
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class Test_Wikipedia_Matrix_Mathematics_Generic
    {

        [Test]
        public void Test_Constructors_int_01()
        {
            Matrix<int> m = new Matrix<int>(2, 3);

            m[1, 1] = 1;
            m[1, 2] = 9;
            m[1, 3] = -13;
            m[2, 1] = 20;
            m[2, 2] = 5;
            m[2, 3] = -6;

            #if MSTEST
            Assert.AreEqual(m[1, 1], 1);
            Assert.AreEqual(m[1, 2], 9);
            Assert.AreEqual(m[1, 3], -13);
            Assert.AreEqual(m[2, 1], 20);
            Assert.AreEqual(m[2, 2], 5);
            Assert.AreEqual(m[2, 3], -6);
            #elif NUNIT
            Assert.AreEqual(m[1, 1], 1);
            Assert.AreEqual(m[1, 2], 9);
            Assert.AreEqual(m[1, 3], -13);
            Assert.AreEqual(m[2, 1], 20);
            Assert.AreEqual(m[2, 2], 5);
            Assert.AreEqual(m[2, 3], -6);
            #elif XUNIT
            Assert.Equal(m[1, 1], 1);
            Assert.Equal(m[1, 2], 9);
            Assert.Equal(m[1, 3], -13);
            Assert.Equal(m[2, 1], 20);
            Assert.Equal(m[2, 2], 5);
            Assert.Equal(m[2, 3], -6);
            #endif

            return;
        }

        [Test]
        public void Test_Constructors_double_02()
        {
            Matrix<double> m = new Matrix<double>(3, 2);

            m[1, 1] = -1.3;
            m[1, 2] = 0.6;
            m[2, 1] = 20.5;
            m[2, 2] = 5.5;
            m[3, 1] = 9.7;
            m[3, 2] = -6.2;

            // copy ctor
            Matrix<double> m1 = new Matrix<double>(m);

            #if MSTEST
            Assert.AreEqual(m1[1, 1], -1.3);
            Assert.AreEqual(m1[1, 2], 0.6);
            Assert.AreEqual(m1[2, 1], 20.5);
            Assert.AreEqual(m1[2, 2], 5.5);
            Assert.AreEqual(m1[3, 1], 9.7);
            Assert.AreEqual(m1[3, 2], -6.2);
            #elif NUNIT
            Assert.AreEqual(m1[1, 1], -1.3);
            Assert.AreEqual(m1[1, 2], 0.6);
            Assert.AreEqual(m1[2, 1], 20.5);
            Assert.AreEqual(m1[2, 2], 5.5);
            Assert.AreEqual(m1[3, 1], 9.7);
            Assert.AreEqual(m1[3, 2], -6.2);
            #elif XUNIT
            Assert.Equal(m1[1, 1], -1.3);
            Assert.Equal(m1[1, 2], 0.6);
            Assert.Equal(m1[2, 1], 20.5);
            Assert.Equal(m1[2, 2], 5.5);
            Assert.Equal(m1[3, 1], 9.7);
            Assert.Equal(m1[3, 2], -6.2);
            #endif

            return;
        }

        [Test]
        public void Test_Constructors_double_03()
        {
            Matrix<double> m = new Matrix<double>(1, 3)
            {
                [1, 1] = 3,
                [1, 2] = 7,
                [1, 3] = 2,
            };

            return;
        }

        [Test]
        public void Test_Constructors_double_04()
        {
            Matrix<double> m = new Matrix<double>(3, 1)
            {
                [1, 1] = 4,
                [2, 1] = 1,
                [3, 1] = 8,
            };

            return;
        }

        [Test]
        public void Test_Constructors_double_05()
        {
            Matrix<double> m = new Matrix<double>(3, 3)
            {
                [1, 1] = 9, [1, 2] = 13, [1, 3] = 5,
                [2, 1] = 1, [2, 2] = 11, [2, 3] = 7,
                [3, 1] = 2, [3, 2] =  6, [3, 3] = 3,
            };

            return;
        }

        [Test]
        public void Test_Operators_Equality_double_01()
        {
            // 
            Matrix<double> lhs = new Matrix<double>(3, 2);

            lhs[1, 1] = -1.3;
            lhs[1, 2] = 0.6;
            lhs[2, 1] = 20.5;
            lhs[2, 2] = 5.5;
            lhs[3, 1] = 9.7;
            lhs[3, 2] = -6.2;

            Matrix<double> rhs = new Matrix<double>(3, 2);

            rhs[1, 1] = -1.3;
            rhs[1, 2] = 0.6;
            rhs[2, 1] = 20.5;
            rhs[2, 2] = 5.5;
            rhs[3, 1] = 9.7;
            rhs[3, 2] = -6.2;

            #if MSTEST
            Assert.IsTrue(lhs == rhs);
            #elif NUNIT
            Assert.IsTrue(lhs == rhs);
            #elif XUNIT
            Assert.True(lhs == rhs);
            #endif
        }

        [Test]
        public void Test_Operators_Equality_double_02()
        {
            Matrix<double> lhs = new Matrix<double>(3, 2);

            lhs[1, 1] = -1.3;
            lhs[1, 2] = 0.6;
            lhs[2, 1] = 20.5;
            lhs[2, 2] = 5.5;
            lhs[3, 1] = 9.7;
            lhs[3, 2] = -6.2;

            Matrix<double> rhs = new Matrix<double>(lhs);

            #if MSTEST
            Assert.IsTrue(lhs == rhs);
            #elif NUNIT
            Assert.IsTrue(lhs == rhs);
            #elif XUNIT
            Assert.True(lhs == rhs);
            #endif
        }

        [Test]
        public void Test_Operators_Addition_double_01()
        {
            Matrix<double> lhs = new Matrix<double>(3, 2);

            lhs[1, 1] = -1.3;
            lhs[1, 2] = 0.6;
            lhs[2, 1] = 20.5;
            lhs[2, 2] = 5.5;
            lhs[3, 1] = 9.7;
            lhs[3, 2] = -6.2;

            Matrix<double> rhs = new Matrix<double>(lhs);

            Matrix<double> result = lhs + rhs;

            Matrix<double> result_expected = new Matrix<double>(3, 2);
            result_expected[1, 1] = -2.6;
            result_expected[1, 2] = 1.2;
            result_expected[2, 1] = 41;
            result_expected[2, 2] = 11;
            result_expected[3, 1] = 19.4;
            result_expected[3, 2] = -12.4;

            #if MSTEST
            Assert.IsTrue(result == result_expected);
            #elif NUNIT
            Assert.IsTrue(result == result_expected);
            #elif XUNIT
            Assert.True(result == result_expected);
            #endif
        }

        //[Test]
        //public void Test_Operators_Sign_Plus_01()
        //{
        //    Matrix<double> lhs = new Matrix<double>(3, 2);

        //    lhs[1, 1] = -1.3;
        //    lhs[1, 2] = 0.6;
        //    lhs[2, 1] = 20.5;
        //    lhs[2, 2] = 5.5;
        //    lhs[3, 1] = 9.7;
        //    lhs[3, 2] = -6.2;

        //    Matrix<double> rhs = +lhs;

        //    rhs[1, 1] = -1.3;
        //    rhs[1, 2] = 0.6;
        //    rhs[2, 1] = 20.5;
        //    rhs[2, 2] = 5.5;
        //    rhs[3, 1] = 9.7;
        //    rhs[3, 2] = -6.2;

        //    #if MSTEST
        //    Assert.IsTrue(lhs.CountRows == rhs.CountRows);
        //    Assert.IsTrue(lhs.CountColumns == rhs.CountColumns);
        //    Assert.IsTrue(lhs == rhs);
        //    #elif NUNIT
        //    Assert.IsTrue(lhs.CountRows == rhs.CountRows);
        //    Assert.IsTrue(lhs.CountColumns == rhs.CountColumns);
        //    Assert.IsTrue(lhs == rhs);
        //    #elif XUNIT
        //    Assert.True(lhs.CountRows == rhs.CountRows);
        //    Assert.True(lhs.CountColumns == rhs.CountColumns);
        //    Assert.True(lhs == rhs);
        //    #endif
        //}

        //[Test]
        //public void Test_Operators_Sign_Minus_01()
        //{
        //    // 
        //    Matrix<double> rhs = new Matrix<double>(3, 2);

        //    rhs[1, 1] = -1.3;
        //    rhs[1, 2] = 0.6;
        //    rhs[2, 1] = 20.5;
        //    rhs[2, 2] = 5.5;
        //    rhs[3, 1] = 9.7;
        //    rhs[3, 2] = -6.2;

        //    Matrix<double> lhs = -rhs;

        //    Matrix<double> lhs_result = new Matrix<double>(3, 2);
        //    lhs_result[1, 1] = 1.3;
        //    lhs_result[1, 2] = -0.6;
        //    lhs_result[2, 1] = -20.5;
        //    lhs_result[2, 2] = -5.5;
        //    lhs_result[3, 1] = -9.7;
        //    lhs_result[3, 2] = +6.2;

        //    #if MSTEST
        //    Assert.IsTrue(lhs == lhs_result);
        //    #elif NUNIT
        //    Assert.IsTrue(lhs == lhs_result);
        //    #elif XUNIT
        //    Assert.True(lhs == lhs_result);
        //    #endif
        //}
    }
}
