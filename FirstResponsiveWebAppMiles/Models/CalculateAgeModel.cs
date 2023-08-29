namespace FirstResponsiveWebAppMiles.Models
{
    public class CalculateAgeModel
    {
        public int Year { get; set; }
        public String? Age { get; set; }
        public DateTime CurrentDate { get; set; }

        public String CalculateAge()
        {
            CurrentDate = DateTime.Now;
            DateTime dateTime = CurrentDate.AddYears(-Year);
            Age = dateTime.ToString("yyyy");
            return Age;
        }
    }
}
