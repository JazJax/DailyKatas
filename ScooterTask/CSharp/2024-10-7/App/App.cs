namespace App;

/*
One person can rent at most one scooter
One scooter can be hired by at most one person
*/

public class App
{
    private Dictionary<string,string> datastore = new();

    public bool RentScooter(string person, string scooter)
    {
        if (datastore.ContainsKey(person))
        {
            return false;
        }

        if(datastore.ContainsValue(scooter))
        {
            return false;
        }

        datastore.Add(person, scooter);
        return true;
    }
}
