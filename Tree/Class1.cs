namespace Tree
{
    internal class main
    {
        static public void Main()
        {
            var batya = new Tree("Раис");
            var sonbatya = new Tree("Арсен", batya);
            var sonsonbatya = new Tree("Вадим", sonbatya);
            var dochasonbatya1 = new Tree("Диана", sonbatya);
            var dochasonbatya2 = new Tree("Риана", sonbatya);
            batya.PrintGraf();
        }
    }
}
