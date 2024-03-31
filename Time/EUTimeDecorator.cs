using System.Text;

namespace Time
{
    public class EUTimeDecorator : Decorator
    {
        public EUTimeDecorator(EUTime ToChange) : base(ToChange) { }
        public override string PrintCurrentDateTime()
        {
            StringBuilder Text = new StringBuilder(ToChange.PrintCurrentDateTime());
            Text.Append(" - Europa");
            return Text.ToString();
        }
    }
}
