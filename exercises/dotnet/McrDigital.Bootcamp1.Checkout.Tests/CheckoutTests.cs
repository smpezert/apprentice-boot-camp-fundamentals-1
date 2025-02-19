namespace McrDigital.Bootcamp1.Checkout.Tests
{
    using Xunit;
    using McrDigital.Bootcamp1.Checkout;
    using System.Runtime.Versioning;

    public class CheckoutTests
    {
        [Fact]
        public void OneA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");

            Assert.Equal(50, checkout.Total);
        }

        [Fact]
        public void TwoA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");

            Assert.Equal(100, checkout.Total);
        }

        [Fact]
        public void ThreeA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.Equal(130, checkout.Total);
        }

        [Fact]
        public void FourA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.Equal(180, checkout.Total);
        }

        [Fact]
        public void SixA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.Equal(260, checkout.Total);
        }


        [Fact]
        public void EightA()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.Equal(360, checkout.Total);
        }

        [Fact]
        public void OneB()
        {
            var checkout = new Checkout();

            checkout.Scan("B");

            Assert.Equal(30, checkout.Total);
        }

        [Fact]
        public void TwoB()
        {
            var checkout = new Checkout();

            checkout.Scan("B");
            checkout.Scan("B");

            Assert.Equal(45, checkout.Total);
        }

        [Fact]
        public void FourB()
        {
            var checkout = new Checkout();

            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("B");

            Assert.Equal(90, checkout.Total);
        }

        [Fact]
        public void FourC()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");

            Assert.Equal(70, checkout.Total);
        }

        [Fact]
        public void EightC()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");
            checkout.Scan("C");

            Assert.Equal(140, checkout.Total);
        }

        [Fact]
        public void FiveD()
        {
            var checkout = new Checkout();
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");

            Assert.Equal(60, checkout.Total);
        }


        [Fact]
        public void TenD()
        {
            var checkout = new Checkout();
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");
            checkout.Scan("D");

            Assert.Equal(120, checkout.Total);
        }

        [Fact]
        public void Simple()
        {
            var checkout = new Checkout();

            checkout.Scan("A");
            Assert.Equal(50, checkout.Total);

            checkout.Scan("B");
            Assert.Equal(80, checkout.Total);

            checkout.Scan("C");
            Assert.Equal(100, checkout.Total);

            checkout.Scan("D");
            Assert.Equal(115, checkout.Total);
        }
    }
}