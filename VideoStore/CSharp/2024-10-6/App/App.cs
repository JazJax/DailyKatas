using System.Linq;

namespace App;

/*
Video rental
- Each person can only rent one video
- Each video can only be rented by one person
*/

public class RentalService
{
    private Dictionary<string, string> rentedFilms = new();
    
    // public App() {
    //     throw new NotImplementedException();
    // }

    public bool RentFilm(string filmTitle, string customer)
    {
        if (rentedFilms.ContainsKey(filmTitle) == true)
        {
            return false;
        }

        if (rentedFilms.Any(x => x.Value == customer) == true)
        {
            return false;
        }

        rentedFilms.Add(filmTitle, customer);
        return true;
    }
}
