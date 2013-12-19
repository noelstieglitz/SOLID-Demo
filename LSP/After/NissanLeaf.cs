namespace After
{
    public class NissanLeaf : Car
    {
        public void ChargeBattery(ChargePercent chargePercent)
        {
            //...
        }
    }

    public enum ChargePercent
    {
        TwentyFive,
        Fifty,
        SeventyFive,
        OneHundred
    }
}