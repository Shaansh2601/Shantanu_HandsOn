using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void whenConvertingMPHToKMPH_thenSuccessfullyConverted() 
        { 
            Movable bugattiVeyron = new BugattiVeyron(); 
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron); 
            assertEquals(bugattiVeyronAdapter.getSpeed(), 431.30312, 0.00001); }
    }
}
