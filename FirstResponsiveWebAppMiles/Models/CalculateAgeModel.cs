using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMiles.Models
{
    public class CalculateAgeModel
    {
        [Required (ErrorMessage ="Please enter your name.")]
        public String? Name { get; set; }
        
        [Required (ErrorMessage ="You must enter a year.")]
        [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]
        public int? Year { get; set; }//var to hold user year born

        public int? CurrentYear { get; set; }
        public int? Age { get; set; }      
        public DateTime CurrentDate { get; set; }

        public String CalculateAge()
        {
            CurrentDate = DateTime.Now; //get current date
            CurrentYear = int.Parse(CurrentDate.ToString("yyyy"));//get current year            
            Age = CurrentYear - Year;//calculating the age            
            return Name + " is " + Age + " years old today!";//returning concat. string
        }
    }
}
