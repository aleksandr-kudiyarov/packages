﻿using Kudiyarov.DoubleExtensions.Constants;
using Xunit;

namespace Kudiyarov.Packages.DoubleExtensions.Tests
{
    public class LessThanTests : BaseDoubleExtensionsTest
    {
        [Fact]
        public void ZeroLessThanTolerance()
        {
            var result = Zero.LessThan(Constants.Tolerance);
            Assert.True(result);
        }
        
        [Fact]
        public void ToleranceNotMoreThanZero()
        {
            var result = Constants.Tolerance.LessThan(Zero);
            Assert.False(result);
        }
        
        [Fact]
        public void AddNotLessThanMultiply()
        {
            var result = Add.LessThan(Multiply);
            Assert.False(result);
        }
        
        [Fact]
        public void MultiplyNotLessThanAdd()
        {
            var result = Multiply.LessThan(Add);
            Assert.False(result);
        }
    }
}