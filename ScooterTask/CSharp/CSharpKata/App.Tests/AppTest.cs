using Xunit;
using App;
using System.Runtime.CompilerServices;

namespace App.Tests;

public class AppShould
{
    private App app;
    private string genericPerson = "Steve Generic";
    private string genericScooter = "AA11 B2C";
    
    public AppShould()
    {
        app = new App();
    }
    
    [Fact]
    public void AllowUserToRentScooter()
    {
        bool result = app.RentScooter(genericPerson, genericScooter);
        Assert.Equal(true, result);
    }

    [Fact]
    public void NotAllowUserToRentSecondScooter()
    {
        bool result1 = app.RentScooter(genericPerson, genericScooter);
        Assert.Equal(true, result1);

        bool result2 = app.RentScooter(genericPerson, genericScooter);
        Assert.Equal(false, result2);
    }

    [Fact]
    public void AllowSecondUserToRentScooter()
    {
        string person1 = "Rich";
        string scooter1 = "NA63 VOH";

        string person2 = "Scott";
        string scooter2 = "BB44 C7Y";
        
        bool result1 = app.RentScooter(person1, scooter1);
        Assert.Equal(true, result1);

        bool result2 = app.RentScooter(person2, scooter2);
        Assert.Equal(true, result2);
    }

    [Fact]
    public void NotAllowAnyPersonToRentSameScooter()
    {
        string scooter = "NA63 VOH";
        string person1 = "Rich";
        string person2 = "Scott";

        bool result1 = app.RentScooter(person1, scooter);
        Assert.Equal(true, result1);

        bool result2 = app.RentScooter(person2, scooter);
        Assert.Equal(false, result2);
    }
}