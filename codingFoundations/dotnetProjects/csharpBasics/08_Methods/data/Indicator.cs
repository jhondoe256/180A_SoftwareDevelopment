
    public class Indicator
    {
        public bool IsFlashing {get;set;}

        public void TurnOn()
        {
            IsFlashing = true;
        }
        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
