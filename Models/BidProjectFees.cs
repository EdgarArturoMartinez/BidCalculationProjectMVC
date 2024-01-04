namespace BidCalculationProjectMVC.Models
{
    public static class BidProjectFees
    {
        public static readonly decimal BasicUserFeePercentage = 0.1m;
        public static readonly decimal CommonCarMinBasicFee = 10.0m;
        public static readonly decimal CommonCarMaxBasicFee = 50.0m;
        public static readonly decimal LuxuryCarMinBasicFee = 25.0m;
        public static readonly decimal LuxuryCarMaxBasicFee = 200.0m;
        public static readonly decimal CommonSellerSpecialFee = 0.02m;
        public static readonly decimal LuxurySellerSpecialFee = 0.04m;
        public static readonly decimal AssociationFee = 0.04m;
        public static readonly decimal StorageFee = 100.0m;
    }
}
