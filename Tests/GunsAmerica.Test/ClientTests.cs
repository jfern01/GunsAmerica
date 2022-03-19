namespace GunsAmerica.Test;
using System;
using Xunit;

public class ClientTests
{
    [Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
    [InlineData("test", "test")]
    [InlineData("test", "")]
    [InlineData("", "test")]
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
    public void Should_NotBeNull_When_Constructed(string clientId, string clientSecret) =>
    Assert.NotNull(new Client(clientId, clientSecret));

    [Theory]
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant
    [InlineData(null, "test")]
    [InlineData("test", null)]
    [InlineData(null, null)]
#pragma warning restore CS3016 // Arrays as attribute arguments is not CLS-compliant
    public void Should_ThrowException_When_CredentialsAreNull(string clientId, string clientSecret) =>
        Assert.Throws<ArgumentNullException>(() => new Client(clientId, clientSecret));
}
