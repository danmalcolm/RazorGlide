using System.ComponentModel;

namespace RazorGlide.Controllers
{
    public class EditorTestModel
    {
        public EditorTestModel()
        {
            ContactInformation = new ContactInformation
            {
                Name = new Name
                {
                    Title = "Mr",
                    FirstName = "Daniel",
                    LastName = "Malcolm"
                }
            };
        }


        public string Name { get; set; } 

        [DisplayName("Name Label")]
        public string Name2 { get; set; }

        public string Name3 { get; set; }

        public ContactInformation ContactInformation { get; set; }
    }
}