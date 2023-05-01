using Parking.Domain.User.ValueObjects;

namespace Parking.Domain.User
{
    public sealed class User : Entity, IAggregateRoot
    {
        public User(string firstName, string lastName, Email email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Email Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}