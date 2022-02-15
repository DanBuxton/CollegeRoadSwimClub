namespace CollegeRoadSwimClub.Domain.Models;

public class Parent : Member
{
    public Parent(string forenames, string surename, string username, string password, string email, string telephoneNumber, string address, DateOnly dOB) : base(forenames, surename, username, password, email, telephoneNumber, address, dOB)
    {
    }

    public Parent(Guid id, string forenames, string surename, string username, string password, string email, string telephoneNumber, string address, DateOnly dOB) : base(id, forenames, surename, username, password, email, telephoneNumber, address, dOB)
    {
    }
}
