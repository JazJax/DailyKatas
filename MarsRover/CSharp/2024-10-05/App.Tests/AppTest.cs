using Xunit;
using App;

namespace App.Tests;

public class AppShould
{
    [Fact]
    public void Exist()
    {
        var app = new App();
        Assert.Equal(1,1);
    }
}