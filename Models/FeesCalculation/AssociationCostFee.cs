namespace BidCalculationProjectMVC.Models.FeesCalculation
{
    public class AssociationCostFee : IFee
    {
        public decimal CalculateFee(int vehicleType, decimal basePrice)
        {
            decimal result = basePrice switch
            {
                _ when basePrice >= 1 && basePrice < 500 => 5.0m,
                _ when basePrice >= 500 && basePrice < 1000 => 10.0m,
                _ when basePrice >= 1000 && basePrice < 3000 => 15.0m,
                _ when basePrice >= 3000 => 20.0m,
                _ => throw new NotImplementedException()
            };
            return result;
        }
    }
}
