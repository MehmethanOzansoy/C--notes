namespace MyApp
{
    public class Canlilar
    {

        protected void Beslenme()
        {
            System.Console.WriteLine("Canlilar beslenir");
        }

        public void Solunum()
        {
            System.Console.WriteLine("Canlılar solunum yapar");
        }

        public void Bosaltim()
        {
            System.Console.WriteLine("Canlilar boşaltım yapar");
        }

        public void Ureme()
        {
            System.Console.WriteLine("Canlılar üreme yapar");
        }

        public virtual void UyaranalarTepki()
        {
            System.Console.WriteLine("Canlılar Uyaranlara tepki");
        }

    }
}