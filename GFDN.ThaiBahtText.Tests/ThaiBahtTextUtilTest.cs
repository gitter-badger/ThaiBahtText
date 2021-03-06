// <copyright file="ThaiBahtTextUtilTest.cs" company="GreatFriends.Biz">Copyright ©  2015</copyright>

using System;
using GreatFriends.ThaiBahtText;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreatFriends.ThaiBahtText.Tests
{
    [TestClass]
    [PexClass(typeof(ThaiBahtTextUtil))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ThaiBahtTextUtilTest
    {

    [PexMethod] 
    public string ThaiBahtText(
        decimal amount,
        UsesEt usesEt,
        Unit unit,
        int decimalPlaces,
        bool appendBahtOnly
    ) {
      string result = ThaiBahtTextUtil.ThaiBahtText(amount, usesEt, unit, decimalPlaces, appendBahtOnly);
      return result;
      // TODO: add assertions to method ThaiBahtTextUtilTest.ThaiBahtText(Decimal, UsesEt, Unit, Int32, Boolean)
    }
  }
}
