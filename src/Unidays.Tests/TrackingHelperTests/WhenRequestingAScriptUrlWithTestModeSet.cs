using System;
using Xunit;
using FluentAssertions;
using System.Web;

namespace Unidays.Tests.TrackingHelperTests
{
    public partial class GivenATrackingHelper
    {
        public class WhenRequestingAScriptUrlWithTestModeSet
        {
            private readonly Uri url;

            public WhenRequestingAScriptUrlWithTestModeSet()
            {
                var directTrackingDetails = new DirectTrackingDetailsBuilder("a partner Id", "GBP", "the transaction")
                                            .WithOrderTotal(209.00m)
                                            .WithItemsUNiDAYSDiscount(13.00m)
                                            .WithCode("a code")
                                            .WithItemsTax(34.50m)
                                            .WithShippingGross(5.00m)
                                            .WithShippingDiscount(3.00m)
                                            .WithItemsGross(230.00m)
                                            .WithItemsOtherDiscount(10.00m)
                                            .WithUNiDAYSDiscountPercentage(10.00m)
                                            .WithNewCustomer(true)
                                            .Build();

                url = new TrackingHelper(directTrackingDetails).TrackingScriptTestUrl();
            }

            [Fact]
            public void TheSchemeShouldBeHttps()
            {
                this.url.Scheme.Should().Be("https");
            }

            [Fact]
            public void TheHostShouldBeTrackingMyunidaysCom()
            {
                this.url.Host.Should().Be("tracking.myunidays.com");
            }

            [Fact]
            public void ThePathShouldBeV1_2RedemptionJs()
            {
                this.url.PathAndQuery.Should().StartWith("/v1.2/redemption/js");
            }

            [Theory]
            [InlineData("PartnerId", "a partner Id")]
            [InlineData("TransactionId", "the transaction")]
            [InlineData("Currency", "GBP")]
            [InlineData("OrderTotal", "209.00")]
            [InlineData("ItemsUNiDAYSDiscount", "13.00")]
            [InlineData("Code", "a code")]
            [InlineData("ItemsTax", "34.50")]
            [InlineData("ShippingGross", "5.00")]
            [InlineData("ShippingDiscount", "3.00")]
            [InlineData("ItemsGross", "230.00")]
            [InlineData("ItemsOtherDiscount", "10.00")]
            [InlineData("UNiDAYSDiscountPercentage", "10.00")]
            [InlineData("NewCustomer", "True")]
            [InlineData("Signature", null)]
            [InlineData("Test", "True")]
            public void TheParameterShouldBeCorrect(string parameter, string result)
            {
                var parameters = HttpUtility.ParseQueryString(this.url.Query);
                parameters[parameter].Should().Be(result);
            }
        }
    }
}
