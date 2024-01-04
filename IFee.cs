namespace BidCalculationProjectMVC
{
    public interface IFee
    {
        decimal CalculateFee(int vehicleType, decimal basePrice);
    }
}
