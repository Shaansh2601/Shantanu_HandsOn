
using Moq;
using NUnit.Framework;
using System;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        Mock<IMailSender> _mock;
        CustomerCom customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IMailSender>(MockBehavior.Strict);
            customerComm = new CustomerCom(_mock.Object);
        }

        [Test]
        [TestCase("cust123@abc.com","Some Message1")]
        [TestCase("cust1234@abc.com", "Some Message2")]
        [TestCase("cust124@abc.com", "Some Message3")]
        public void SendMailToCustomer_whenCalled_SendMailAndReturnTrue(string email,string message)
        {
            _mock.Setup(p => p.SendMail(email,message)).Returns(true);
            bool result = customerComm.SendMailToCustomer(email,message);
            Assert.AreEqual(result,true);
        }
    }
}
