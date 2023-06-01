namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Bitkiler : Canlilar
    {

        protected void Fotosentez()
        {
            System.Console.WriteLine("Bitkiler fotosentez yapar");
        }

        public override void UyaranalarTepki()
        {
            // base.UyaranalarTepki();
            System.Console.WriteLine("Bitkiler Güneşe tepki verir");
        }


    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.UyaranalarTepki();
        }
        public void TohumluBitki()
        {
            System.Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public void TohumsuzBitki()
        {
            System.Console.WriteLine("Tohumlu bitkiler sporla çoğalır");
        }
    }



}