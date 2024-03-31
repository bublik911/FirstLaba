namespace Time
{
    public class Decorator : AbstractTime
    {
        public readonly AbstractTime ToChange;

        public Decorator(AbstractTime change)
        {
            this.ToChange = change;
        }

        public override string PrintCurrentDateTime()
        {
            return ToChange.PrintCurrentDateTime();
        }
    }
}
