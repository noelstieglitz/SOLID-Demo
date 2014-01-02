namespace Before
{
    public abstract class Car
    {
        protected decimal _gas;
        protected bool _isOn;

        public virtual void Start()
        {
            _isOn = true;
        }

        public virtual void GetGas(decimal gallons)
        {
            _gas += gallons;
        }
    }
}