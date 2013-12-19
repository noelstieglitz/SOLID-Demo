namespace After
{
    public abstract class Car
    {
        protected bool _isOn;

        public virtual void Start()
        {
            _isOn = true;
        }
    }
}