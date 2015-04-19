namespace RazorGlide.Controllers
{
    public class ContactInformation
    {
        public Name Name { get; set; }
    }

    public class Name
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}