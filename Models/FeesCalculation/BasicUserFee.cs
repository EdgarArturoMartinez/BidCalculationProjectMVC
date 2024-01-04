namespace BidCalculationProjectMVC.Models.FeesCalculation
{
    public class BasicUserFee : IFee
    {
        public decimal CalculateFee(int vehicleType, decimal basePrice)
        {

            var result = vehicleType switch
            {
                0 => CommonCar(basePrice),
                1 => LuxuryCar(basePrice),
                _ => throw new NotImplementedException()
            };
            return result;
        }

        private static decimal CommonCar(decimal basePrice)
        {
            var result = basePrice * BidProjectFees.BasicUserFeePercentage;
            var basicUserFee = result switch
            {
                _ when result < BidProjectFees.CommonCarMinBasicFee => BidProjectFees.CommonCarMinBasicFee,
                _ when result > BidProjectFees.CommonCarMaxBasicFee => BidProjectFees.CommonCarMaxBasicFee,
                _ => result
            };
            return basicUserFee;
        }

        private static decimal LuxuryCar(decimal basePrice)
        {
            var result = basePrice * BidProjectFees.BasicUserFeePercentage;
            var basicUserFee = result switch
            {
                _ when result < BidProjectFees.LuxuryCarMinBasicFee => BidProjectFees.LuxuryCarMinBasicFee,
                _ when result > BidProjectFees.LuxuryCarMaxBasicFee => BidProjectFees.LuxuryCarMaxBasicFee,
                _ => result
            };
            return basicUserFee;
        }


    }
}
