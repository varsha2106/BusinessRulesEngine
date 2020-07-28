using System;
using NUnit.Framework;

namespace BusinessRulesEngineTest
{
    [TestFixture]
    public class PaymentTest
    {
        [Test]
        public void DoPostPaymentTest_ForPhysicalProduct_GeneratesAPackagingSlip()
        {
            //Arrange
            bool expectedResult = true;
             PhysicalProductsPayment physicalProductsPayment= new PhysicalProductsPayment();
            //Act
            bool isPackagingSlipGenerated=physicalProductsPayment.DoPostPayment();
            //Assert
            Assert.That(isPackagingSlipGenerated,Is.EqualTo(expectedResult));
        }
    }
}
