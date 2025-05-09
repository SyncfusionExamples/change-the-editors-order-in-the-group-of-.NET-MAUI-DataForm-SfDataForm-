﻿using Syncfusion.Maui.DataForm;
using System.ComponentModel.DataAnnotations;

namespace EditorOrderWithEvent
{
    public class DataFormModel
    {
        [Display(GroupName = "General Information", Prompt = "Enter your last name")]
        public string LastName { get; set; } = string.Empty;

        [Display(GroupName = "General Information")]
        public Gender Gender { get; set; }

        [Display(GroupName = "General Information", Prompt ="Enter your first name")]
        public string FirstName { get; set; } = string.Empty;   

        [Display(GroupName = "Educational Information")]
        public DateTime GraduationDate { get; set; }

        [Display(GroupName = "Educational Information", Prompt = "Enter your degree")]
        public string Degree { get; set; } = string.Empty;

        [Display(GroupName = "Educational Information")]
        public string Branch { get; set; } = string.Empty;
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}