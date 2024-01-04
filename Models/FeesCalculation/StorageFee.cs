namespace BidCalculationProjectMVC.Models.FeesCalculation
{
    public class StorageFee : IFee
    {
        public decimal CalculateFee(int vehicleType, decimal basePrice)
        {
            return BidProjectFees.StorageFee;
        }
    }
}
