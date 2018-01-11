namespace Entities
{
    interface IUser
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string StreetAddress { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Avatar { get; set; }
        string AdminNotes { get; set; }
        bool Administrator { get; set; }
        bool Member { get; set; }
        bool PendingMember { get; set; }
        bool TextNewMember { get; set; }
        bool TextNewActivity { get; set; }
        bool TextChangeMyActivity { get; set; }
        bool TextNewBook { get; set; }
        bool TextNewBBPost { get; set; }
        bool EmailNewMember { get; set; }
        bool EmailNewActivity { get; set; }
        bool EmailChangeMyActivity { get; set; }
        bool EmailNewBook { get; set; }
        bool EmailNewBBPost { get; set; }
    }
}
