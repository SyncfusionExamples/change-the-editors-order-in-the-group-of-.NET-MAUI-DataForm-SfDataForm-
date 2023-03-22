using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace EditorOrderWithAttribute
{
    public class DataFormModel
    {
        [Display(GroupName = "General Information", Order = 1, Prompt = "Enter your last name")]
        public string LastName { get; set; }

        [Display(GroupName = "General Information", Order = 2)]
        public Gender Gender { get; set; }

        [Display(GroupName = "General Information", Order = 0, Prompt = "Enter your first name")]
        public string FirstName { get; set; }

        [Display(GroupName = "Educational Information")]
        [DataFormDisplayOptions(RowOrder = 2)]
        public DateTime GraduationDate { get; set; }

        [Display(GroupName = "Educational Information", Prompt = "Enter your degree")]
        [DataFormDisplayOptions(RowOrder = 0)]
        public string Degree { get; set; }

        [Display(GroupName = "Educational Information")]
        [DataFormDisplayOptions(RowOrder = 1)]
        public string Branch { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}