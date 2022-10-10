using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_İçecek
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
            if(secim=='c'||secim=='C')
            {
                Console.WriteLine("Seçiminiz Çay oldu!");
            }
            else if (secim == 'k' || secim == 'K')
            {
                Console.WriteLine("Seçiminiz Kola oldu!");
            }
            else if (secim == 'l' || secim == 'L')
            {
                Console.WriteLine("Seçiminiz Limonata oldu!");
            }
            else
            {
                Console.WriteLine("Yanlış bir tuşlama yaptınız! Lütfen seçiminizi yeniden yapınız.");
                goto secimYeniden;
            }
            Console.Read();
        }
    }
}
