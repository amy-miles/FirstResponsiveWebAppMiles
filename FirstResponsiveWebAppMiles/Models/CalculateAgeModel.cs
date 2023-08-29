namespace FirstResponsiveWebAppMiles.Models
{
    public class CalculateAgeModel
    {
        public String? Name { get; set; }
        public int Year { get; set; }
        public String? Age { get; set; }
        public String AgeTrimmed { get; set; }
        public DateTime CurrentDate { get; set; }

        public String CalculateAge()
        {
            CurrentDate = DateTime.Now; //get current date
            DateTime dateTime = CurrentDate.AddYears(-Year);
            Age = dateTime.ToString("yyyy");
            AgeTrimmed = Age.TrimStart(new Char[] { '0' });
            return Name + " is " + AgeTrimmed + " years old today!";
        }
    }
}
