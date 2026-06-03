using System;

namespace Egzamin
{
    public class Program
    {
        static int[] tablica = new int[10];
        static void Main()
        {

            

            for(int i = 0;i < tablica.Length; i++)
            {

                Console.Write($"Podaj wartość {i+1} elementu tablicy: \n");
                
                tablica[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            SortowaniePrzezWybieranie();
            WyswietlTablice();
            Console.WriteLine($"Najwyższa wartość w tablicy to {WyszukiwanieWartosciMaksymalnej()}");

        }
        static void WyswietlTablice()
        {

            foreach(int liczba in tablica)
            {

                Console.Write($"{liczba}, ");

            }

        }
        /********************************************************
* nazwa funkcji: SortowaniePrzezWybieranie
* parametry wejściowe: brak
* wartość zwracana: brak
* autor: <numer PESEL zdającego>
* ****************************************************/
        static void SortowaniePrzezWybieranie()
        {
            int maksymalnaWartoscIndeks;
            int temp;
            for(int i = 0;i < tablica.Length-1; i++)
            {
                maksymalnaWartoscIndeks = i;
                    for(int j = i+1;j < tablica.Length; j++)
                {

                    if (tablica[j] > tablica[maksymalnaWartoscIndeks])
                    {

                        maksymalnaWartoscIndeks = j;

                    }

                     
                }

                temp = tablica[i];
                tablica[i] = tablica[maksymalnaWartoscIndeks];
                tablica[maksymalnaWartoscIndeks] = temp;





            }

        }
        /********************************************************
* nazwa funkcji: WyszukiwanieWartosciMaksymalnej
* parametry wejściowe: brak
* wartość zwracana: funckja zwraca maksymalną wartość w tablicy
* autor: <numer PESEL zdającego>
* ****************************************************/
        private static int WyszukiwanieWartosciMaksymalnej()
        {
            int maksymalnaWartosc = tablica[0];
            for(int i =0;i< tablica.Length;i++)
            {

                if (tablica[i] > maksymalnaWartosc)
                {

                    maksymalnaWartosc = tablica[i];

                }

            }
            return maksymalnaWartosc;

        }


    }


}
