namespace ConsoleApp58
{
    public class Program
    {
        static void Main(string[] args)
        {
            double m1 = 10.0;
            double m2 = 15.0;
            double m3 = 20.0;

            double odenecekMebleg = OdenecekMeblegiHesabla(m1, m2, m3);
            Console.WriteLine("Ödənəcək məbləğ: " + odenecekMebleg);
        }

        static double OdenecekMeblegiHesabla(double m1, double m2, double m3)
        {
        
            double enBahali1 = Math.Max(m1, m2);
            double enBahali2 = Math.Max(enBahali1, m3);
            double enBahaliQiymet = enBahali2;

            double pulsuzMehsulQiymet = m1 + m2 + m3 - enBahaliQiymet;

            return enBahali1 + enBahali2;
        }
    }
}
    