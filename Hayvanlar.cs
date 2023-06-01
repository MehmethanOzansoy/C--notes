namespace MyApp // Note: actual namespace depends on the project name.
{

    public class Hayvanlar : Canlilar
    {

        public void Adaptasyon()
        {
            System.Console.WriteLine("Hayvanlar adaptasyon yapar");
        }


        public override void UyaranalarTepki()
        {
            base.UyaranalarTepki();
            System.Console.WriteLine("Hayvanlar uyaranlara tepki verir");
        }

    }

    public class Sürüngenler : Hayvanlar
    {
        public void Sürüngen()
        {
            System.Console.WriteLine("Sürüngenler adaptasyon yapmaz");

        }
    }

    public class Kuslar : Hayvanlar
    {

        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Ureme();
            base.Solunum();
            base.UyaranalarTepki();
        }
        public void Ucmak()
        {
            System.Console.WriteLine("Kuşlar uçar");
        }
    }
}