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

using Core.Math.Matrix;

namespace UnitTests.Core.Math.Core.Math.Matrix
{
    public partial class UnitTests20200412
    {
        //@TODO: constructor API
        [Test]
        public void Vector_Constructor_Value_Size()
        {
            Vector<double> v = new Vector<double>(3.14, 10);

            string sv = v.ToString();

            Console.WriteLine($" v = {sv}");

            return;
        }

        [Test]
        public void Vector_Constructor_Value_Scalar()
        {
            Vector<double> v = new Vector<double>(3.14);

            // TODO: ToString() as C# string
            // BODY: return string that can be copy/paste-d to code as valid C#
            string sv = v.ToString();

            Console.WriteLine($" v = {sv}");

            return;
        }

        [Test]
        public void Vector_Constructor_Initializer()
        {
            Vector<double> v = new Vector<double> { 3.14, 3.14 };

            string sv = v.ToString();

            Console.WriteLine($" v = {sv}");

            return;
        }

        [Test]
        public void Vector_Operations_Algebra_Addition_01()
        {
            Vector<int> v1 = new Vector<int> { 2, 3 };
            Vector<int> v2 = new Vector<int> { 4, 4 };

            Vector<int> vr = Vector<int>.Add(v1, v2);

            string sv = vr.ToString();

            Console.WriteLine($" v = {sv}");

            return;
        }

        [Test]
        public void Vector_Operations_Algebra_Addition_02()
        {
            Vector<int> v1 = new Vector<int> { 2, 3, 5};
            Vector<int> v2 = new Vector<int> { 4, 4 };

            Vector<int> vr = null;

            #if NUNIT && NUNIT_LITE
            Assert.Throws<InvalidOperationException>
            (
                () =>
                {
                    vr = Vector<int>.Add(v1, v2);
                    string sv = vr.ToString();

                    Console.WriteLine($" v = {sv}");
                }
            );
            #endif


            return;
        }
    }
}
