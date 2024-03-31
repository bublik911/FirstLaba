using System;
using System.Globalization;

namespace Time
{
    public class USTime : AbstractTime
    {
        CultureInfo myCIintl = new CultureInfo("en-US", false);
        public override string PrintCurrentDateTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }
}
