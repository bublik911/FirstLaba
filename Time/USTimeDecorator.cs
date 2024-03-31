using System.Text;

namespace Time
{
    public class USTimeDecorator : Decorator
    {
        public USTimeDecorator(USTime ToChange) : base(ToChange) { }
        public override string PrintCurrentDateTime()
        {
            StringBuilder Text = new StringBuilder(ToChange.PrintCurrentDateTime());
            Text.Append(" - America");
            return Text.ToString();
        }
    }
}
