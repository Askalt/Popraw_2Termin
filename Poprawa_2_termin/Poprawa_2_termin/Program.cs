using System;
using System.Collections.Generic;
using System.Linq;

namespace Poprawa_2_termin
{
    class Połaczenie
    {
        public int numer;
        DateTime data;
        TimeSpan czas;

        public Połaczenie(int numer, DateTime data, TimeSpan czas)
        {
            this.numer = numer;
            this.data = data;
            this.czas = czas;
        }
    }

    static class ExtensionMethod
    {
        public static decimal Netto(this decimal liczba_a,decimal liczba_b)
        {

            return (liczba_a * liczba_b);
        }
    }
   public class Postac
    {
       public int hp, status,status_b;

        public Postac(int hp, int status)
        {
            this.hp = hp;
            this.status = status;
         
        }

        public void Kolejka()
        {
            
        }
       
    }
    public class Wiadomosc
    {
        public string tresc, autor;
        public DateTime data;

        public Wiadomosc(string tresc, string autor, DateTime data)
        {
            this.tresc = tresc;
            this.autor = autor;
            this.data = data;
        }

        public void Deconstruct(out string tresc,out string autor,out DateTime data)
        {
            tresc = this.tresc;
            autor = this.autor;
            data = this.data;
        }
        public void Deconstruct(out string tresc,out DateTime data)
        {
            tresc = this.tresc;
            data = this.data;
        }
    }

    public abstract class Dzielo
    {
        public string nr_karty, tytul;


         virtual public void Opis()
        {
            Console.WriteLine($"{nr_karty} {tytul}");
        }
    }

    public class Ksiazka : Dzielo
    {

      
    }
    public class Czasopismo : Dzielo
    {
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 2
            decimal liczba_start = 10;
            Console.WriteLine(liczba_start.Netto(Convert.ToDecimal(1.23)));
            //Zadanie 3
            Postac w_1 = new Postac(10,1);
            Console.WriteLine($"HP:{w_1.hp} Status:{w_1.status}");
            if (w_1.status==1)
            {
                Console.WriteLine("Status: Normalny");
            }
            //Zadanie 4
            DateTime b = new DateTime(2020, 06, 02);
            Wiadomosc wiadomosc = new Wiadomosc("Pogoda", "XYZ", DateTime.Now);
            Wiadomosc wiadomosc_1 = new Wiadomosc("Pogoda", "XYZ", DateTime.Now);
            var (tresc, autor, data) = wiadomosc;
            var (tresc_1, data_1) = wiadomosc_1;
            Console.WriteLine($"{wiadomosc.tresc},{wiadomosc.autor} o {wiadomosc.data}");
            Console.WriteLine($"Ilość znaków wiadomośći: {wiadomosc_1.tresc.Length} Dni od {b.Year}:{b.Month}:{b.Day}|| Mieło {wiadomosc_1.data.Day-b.Day}");
            //Zadanie 1
            IEnumerable<int> connect = Enumerable.Range(1, 50).ToList();
            foreach (var item in connect)
            {
                Console.WriteLine($"{item}");
            }
            //Zadanie 5
            Dzielo dzielo = new Ksiazka();
            
            

        }
    }
}

//        if (status_1==0&&status_2==0&&status_3==0&&status_4==0)
//            {
//                string napis;
//Console.WriteLine("Postać ma status:Normalny");
//                napis = Console.ReadLine();
//            }
//            else if(status_1 == 1 && status_2 == 0 && status_3 == 0 && status_4 == 0)
//                {
//                Console.WriteLine("Postać status:Trucizna");
//                hp = 8;
//                }