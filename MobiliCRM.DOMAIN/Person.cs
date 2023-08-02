
namespace MobiliCRM.DOMAIN
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailIsValid { get; set; }    
        public string Phone { get; set; }
        public bool PhoneIsValid { get; set; }
        public string CPF { get; set; }
        public enum Gender { Male, Female }
        public DateTime BirthDate { get; set; }
        public DateTime CreationDate { get; set; }
        //public User User { get; set; }
        //public Address Address { get; set; }

    }
}