using AppSample.Domain.Abstractions;

namespace AppSample.Domain;

public sealed class User : Entity
{
    private User(Guid id, string firstName, string lastName)
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    private User()
    { }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
}
