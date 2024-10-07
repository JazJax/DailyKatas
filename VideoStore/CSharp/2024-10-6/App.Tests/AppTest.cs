using Xunit;
using App;

namespace App.Tests;

public class RentalServiceShould
{
    RentalService app;
    
    public RentalServiceShould()
    {
        app = new RentalService();
    }
    
    [Fact]
    public void Exist()
    {
        Assert.Equal(1,1);
    }

    [Fact]
    public void AllowCustomerToRentAFilm()
    {
        string customer = "Jasper";
        bool result = app.RentFilm(customer,"The War of the Worlds");
        Assert.True(result);
    }

    [Fact]
    public void NotAllowFilmToBeRentedTwice()
    {
        string customer = "Jasper";
        string filmTitle = "The War of the Worlds";
        bool result1 = app.RentFilm(customer, filmTitle);
        Assert.True(result1);

        bool result2 = app.RentFilm(customer, filmTitle);
        Assert.False(result2);
    }

    [Fact]
    public void NotAllowCustomerToRentTwoFilms()
    {
        string customer = "Jasper";
        bool result1 = app.RentFilm("The War of the Worlds", customer);
        Assert.True(result1);
        
        bool result2 = app.RentFilm("Hollow Man", customer);
        Assert.False(result2);
    }
}