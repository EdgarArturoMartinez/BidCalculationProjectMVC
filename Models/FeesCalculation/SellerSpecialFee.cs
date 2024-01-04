namespace BidCalculationProjectMVC.Models.FeesCalculation
{
    public class SellerSpecialFee : IFee
    {
        public decimal CalculateFee(int vehicleType, decimal basePrice)
        {

            var result = vehicleType switch
            {
                0 => basePrice * BidProjectFees.CommonSellerSpecialFee,
                1 => basePrice * BidProjectFees.LuxurySellerSpecialFee,
                _ => throw new NotImplementedException()
            };
            return result;
        }
    }
}
