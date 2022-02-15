namespace CollegeRoadSwimClub.Domain.Models;

public class Member
{
    public Guid? Id { get; set; }

    public string Forenames { get; set; }
    public string Surename { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }

    public string Email { get; set; }
    public string TelephoneNumber { get; set; }
    public string Address { get; set; }

    public DateOnly DOB { get; set; }

    protected Member(
        string forenames,
        string surename,
        string username,
        string password,
        string email,
        string telephoneNumber,
        string address,
        DateOnly dOB)
    {
        Forenames = forenames;
        Surename = surename;
        Username = username;
        Password = password;
        Email = email;
        TelephoneNumber = telephoneNumber;
        Address = address;
        DOB = dOB;
    }
    protected Member(
        Guid id,
        string forenames,
        string surename,
        string username,
        string password,
        string email,
        string telephoneNumber,
        string address,
        DateOnly dOB)
    {
        Id = id;
        Forenames = forenames;
        Surename = surename;
        Username = username;
        Password = password;
        Email = email;
        TelephoneNumber = telephoneNumber;
        Address = address;
        DOB = dOB;
    }

    public int Age
    {
        get
        {
            // From https://stackoverflow.com/a/1404

            // Save today's date.
            var today = new DateOnly(DOB.Year, DOB.Month, DOB.Day);

            // Calculate the age.
            var age = today.Year - DOB.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (DOB > today.AddYears(-age)) age--;

            return age;
        }
    }
}
