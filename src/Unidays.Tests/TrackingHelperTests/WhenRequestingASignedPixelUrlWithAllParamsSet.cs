using System;
using Xunit;
using FluentAssertions;
using System.Web;

namespace Unidays.Tests.TrackingHelperTests
{
    public partial class GivenATrackingHelper
    {
        public class WhenRequestingASignedPixelUrlWithAllParamsSet
		{
            private readonly Uri url;

            public WhenRequestingASignedPixelUrlWithAllParamsSet()
            {
	            var directTrackingDetails = new DirectTrackingDetailsBuilder("a customer Id", "GBP", "the transaction")
	                                        .SetOrderTotal(209.00m)
	                                        .SetItemsUNiDAYSDiscount(13.00m)
	                                        .SetCode("a code")
	                                        .SetItemsTax(34.50m)
	                                        .SetShippingGross(5.00m)
	                                        .SetShippingDiscount(3.00m)
	                                        .SetItemsGross(230.00m)
	                                        .SetItemsOtherDiscount(10.00m)
	                                        .SetUNiDAYSDiscountPercentage(10.00m)
	                                        .SetNewCustomer(true)
	                                        .Build();

	            url = new TrackingHelper(directTrackingDetails).TrackingPixelUrl(new byte[4]);
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
            public void ThePathShouldBePerksRedemptionV1()
            {
                this.url.PathAndQuery.Should().StartWith("/perks/redemption/v1.2.gif");
            }

            [Theory]
            [InlineData("CustomerId", "a customer Id")]
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
            [InlineData("Signature", "BF4pIsf2d+W+JQYnca2pOtJIbg+XKSEVv0GoI18vYifuzAAv4O+xpvgCDbXods47NnNhwoBnVTiTndh5YRuAeQ==")]
            public void TheParameterShouldBeCorrect(string parameter, string result)
            {
                var parameters = HttpUtility.ParseQueryString(this.url.Query);
                parameters[parameter].Should().Be(result);
            }
        }
    }
}