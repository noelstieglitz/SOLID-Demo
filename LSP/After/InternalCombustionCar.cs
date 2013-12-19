namespace After
{
    public abstract class InternalCombustionCar : Car
    {
        protected decimal _gas;
        
        public virtual void GetGas(decimal gallons)
        {
            _gas += gallons;
        }
    }
}