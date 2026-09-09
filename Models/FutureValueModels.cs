using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModels
    {
        [Required(ErrorMessage ="Please enter a monthly investment.")]
        [Range(1,500, ErrorMessage = "Monthly investment must be between 1 and 500.")]
        public decimal MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a yearly interest rate.")]
        [Range(.1, 10.0,  ErrorMessage = "Yearly interest rate must be between .01 and 10.0.")]
        public decimal YearlyInterestRate { get; set; }

        [Required(ErrorMessage ="Please enter the number of years.")]
        [Range(1,50, ErrorMessage = "Number of yeats must be between 1 and 50.")]
        public int Years { get; set; }

        public decimal CalulatedFutureValue()
        {
            int months = Years * 12;
            decimal monthlyIntersetRate = YearlyInterestRate / 12 / 100; decimal futureValue = 0; for(int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyIntersetRate);
            }
            return futureValue;
        }
    }
}
