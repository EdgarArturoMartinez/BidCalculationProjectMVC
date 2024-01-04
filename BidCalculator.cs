using BidCalculationProjectMVC.Models;
using BidCalculationProjectMVC.Models.FeesCalculation;

namespace BidCalculationProjectMVC
{

    public class BidCalculator
    {
        private readonly IFee[] fees;

        public BidCalculator()
        {
            fees = new IFee[] { new BasicUserFee(), new SellerSpecialFee(), new AssociationCostFee(), new StorageFee() };
        }

        public decimal CalculateTotalCost(VehicleViewModel vehicle)
        {
            decimal totalCost = vehicle.BasePrice;
            
            foreach (var fee in fees)
            {                
                totalCost += fee.CalculateFee((int)vehicle.VehicleType, vehicle.BasePrice);                
            }

            return totalCost;            
        }

        public List<string> GetFeesDetails(VehicleViewModel vehicle)
        {
            var feesDetails = new List<string>();

            foreach (var fee in fees)
            {
                decimal feeValue = fee.CalculateFee((int)vehicle.VehicleType, vehicle.BasePrice);
                feesDetails.Add($"{fee.GetType().Name}: {feeValue.ToString("C")}");
            }

            return feesDetails;
        }
    }
}
