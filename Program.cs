using System;
using System.Collections.Generic;

namespace Kompozyt
{
    public interface Kompozyt
    {
        public string Nazwa { get; set; }
        void Renderuj();
        void DodajElement(Kompozyt element);
        void UsunElement(Kompozyt element);
    }

    public class Lisc : Kompozyt
    {

        public string Nazwa { get; set; }

        public void Renderuj()
        {
            Console.WriteLine("Liść " + Nazwa+ " renderowanie...");
        }

        public Lisc(string nazwa)
        {
            this.Nazwa= nazwa; 
        }


        // konstruktor
        public void DodajElement(Kompozyt element)
        {
            
        }
        public void UsunElement(Kompozyt element)
        {
            
        }
        

    }


    public class Wezel : Kompozyt
    {
        public Wezel(string nazwa)
        {
            this.Nazwa = nazwa;
        }

        private List<Kompozyt> Lista = new List<Kompozyt>();

        public string Nazwa { get; set; }

        public void Renderuj()
        {
            Console.WriteLine(Nazwa+" rozpoczęcie renderowania");
            

            foreach (Kompozyt item in Lista)
            {
                item.Renderuj();
            }

            Console.WriteLine(Nazwa+" zakończenie renderowania");
        }
        public void DodajElement(Kompozyt element)
        {
            Lista.Add(element);
        }
        public void UsunElement(Kompozyt element)
        {
            Lista.Remove(element);
        }

    }
  
    class MainClass
    {
        public static void Main(string[] args)
        {

            Wezel korzen=new Wezel("Korzeń");
            Wezel wezel1 = new Wezel("Węzeł 2");
            Wezel wezel2 = new Wezel("Węzeł 3");
            Wezel wezel3 = new Wezel("Węzeł 3.3");
            


            korzen.DodajElement(new Lisc("1.1"));
            korzen.DodajElement(wezel1);
            korzen.DodajElement(wezel2);

            wezel1.DodajElement(new Lisc("2.1"));
            wezel1.DodajElement(new Lisc("2.2"));
            wezel1.DodajElement(new Lisc("2.3"));

            wezel2.DodajElement(new Lisc("3.1"));
            wezel2.DodajElement(new Lisc("3.2"));
            wezel2.DodajElement(wezel3);

            wezel3.DodajElement(new Lisc("3.3.1"));

            korzen.Renderuj();
        }
    }
}
