using System;
using System.Globalization;

namespace Time
{
    public class EUTime : AbstractTime
    {
        CultureInfo myCIintl = new CultureInfo("es-ES", false);
        public override string PrintCurrentDateTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }
}
