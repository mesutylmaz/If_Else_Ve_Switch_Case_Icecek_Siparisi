using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_İçecek_Seçimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //İçecek koduna göre (C:Çay, L:Limonata, K:Kola içecek tercihini ekrana yazdıran program:

            Console.WriteLine(Environment.NewLine + "Hoşgeldiniz.");
            Console.WriteLine(Environment.NewLine + "Lütfen içeceğinizi kodlayın: ");

            secimYeniden:
            Console.WriteLine(Environment.NewLine + "Lütfen Çay için 'C' yada 'c' tuşlayınız.");
            Console.WriteLine(Environment.NewLine + "Lütfen Kola için 'K' yada 'k' tuşlayınız.");
            Console.WriteLine(Environment.NewLine + "Lütfen Limonata için 'L' yada'l' tuşlayınız.");

            char secim = char.Parse(Console.ReadLine());

            switch (secim)
            {
                case 'C':
                case 'c':
                    {
                        Console.WriteLine("Seçiminiz Çay oldu!");
                        break;
                    }
                case 'K':
                case 'k':
                    {
                        Console.WriteLine("Seçiminiz Kola oldu!");
                        break;
                    }
                case 'L':
                case 'l':
                    {
                        Console.WriteLine("Seçiminiz Limonata oldu!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Yanlış bir tuşlama yaptınız! Lütfen seçiminizi yeniden yapınız.");
                        goto secimYeniden;
                    }
            }
            Console.Read();
        }
    }
}
