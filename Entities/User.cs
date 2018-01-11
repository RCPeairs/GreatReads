namespace Entities
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string AdminNotes { get; set; }
        public bool Administrator { get; set; }
        public bool Member { get; set; }
        public bool PendingMember { get; set; }
        public bool TextNewMember { get; set; }
        public bool TextNewActivity { get; set; }
        public bool TextChangeMyActivity { get; set; }
        public bool TextNewBook { get; set; }
        public bool TextNewBBPost { get; set; }
        public bool EmailNewMember { get; set; }
        public bool EmailNewActivity { get; set; }
        public bool EmailChangeMyActivity { get; set; }
        public bool EmailNewBook { get; set; }
        public bool EmailNewBBPost { get; set; }
    }
}
