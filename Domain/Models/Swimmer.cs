namespace CollegeRoadSwimClub.Domain.Models;

public class Swimmer : Member
{
    public Parent Parent { get; set; }

    public Swimmer(
        string forenames,
        string surename,
        string username,
        string password,
        string email,
        string telephoneNumber,
        string address,
        DateOnly dob,
        Parent parent) : base(forenames, surename, username, password, email, telephoneNumber, address, dob)
    {
        Parent = parent;
    }
    public Swimmer(
        Guid id,
        string forenames,
        string surename,
        string username,
        string password,
        string email,
        string telephoneNumber,
        string address,
        DateOnly dob,
        Parent parent) : base(id, forenames, surename, username, password, email, telephoneNumber, address, dob)
    {
        Parent = parent;
    }
}
