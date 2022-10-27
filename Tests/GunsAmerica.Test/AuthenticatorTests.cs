namespace GunsAmerica.Test;

using System.Globalization;
using GunsAmerica;
using GunsAmerica.Models;
using Xunit;

public class AuthenticatorTests
{
    [Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
    [InlineData("test", "test")]
    [InlineData("test", "")]
    [InlineData("", "test")]
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
    public void Should_NotBeNull_When_Constructed(string clientId, string clientSecret) =>
        Assert.NotNull(new Authenticator(clientId, clientSecret));

    [Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
    [InlineData(null, "test")]
    [InlineData("test", null)]
    [InlineData(null, null)]
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
    public void Should_ThrowException_When_CredentialsAreNull(string clientId, string clientSecret) =>
        Assert.Throws<ArgumentNullException>(() => new Authenticator(clientId, clientSecret));

    [Fact]
    public async Task Should_Authenticate_Async()
    {
        var client = new Client("247295e83c91a7-7", "9fbeb720-7491-46f4-9432-25c1fd89c881");

        var items = await client.GetItemsAsync().ConfigureAwait(false);

        items = await client.GetItemsAsync().ConfigureAwait(false);

        Assert.NotNull(items);
    }
}
