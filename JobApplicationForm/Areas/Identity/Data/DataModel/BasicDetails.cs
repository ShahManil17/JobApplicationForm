﻿using System.ComponentModel.DataAnnotations;

namespace JobApplicationForm.Areas.Identity.Data.DataModel
{
    public class BasicDetails
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        [RegularExpression(@"^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid Mail Entered")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        [StringLength(10, ErrorMessage = "Invalid Number Entered", MinimumLength = 10)]
        [Display(Name = "Contact Number")]
        public string? PhoneNo { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "This Field Must Be Filled Out")]
        [Display(Name = "Relationship Status")]
        public string? RelationshipStatus { get; set; }
    }
}
