using System;
using System.IO;
using System.Collections.Generic;

class Rendszer
{
    static void Main()
    {
        Szoftver();
    }
    static void Szoftver()
    {
        string fajl = "adatok.txt";
        string[] adatok = new string[100];

        Dictionary<string, string> bent = new();

        while (true)
        {
            Console.WriteLine("1. gomb: belépés");
            Console.WriteLine("2. gomb: távozás");
            Console.WriteLine("3. gomb: keresés");
            Console.WriteLine("4. gomb: kilépés a programból");
            Console.Write("Adja meg a ki választött opciót (1-4): ");
            string gomb = Console.ReadLine();

            if (gomb == "4")
            {
                Console.WriteLine("Kilépés a programból...");
                break;
            }

            else if (gomb == "1")
            {
                Console.WriteLine("Adja meg az érkező típusát (autó, motor, roller, kerékpár vagy gyalog): ");
                string tipus = Console.ReadLine().ToLower().ToLower().Trim();
                if (tipus == "autó")
                {
                    Console.Write("Add meg a rendszámot: ");
                    string rendszam = Console.ReadLine();

                    if (rendszam == "")
                    {
                        Console.WriteLine("Nem adott meg rendszámot!");
                        continue;
                    }

                    else{
                        if (bent.ContainsKey(rendszam))
                        {
                            Console.WriteLine("Ez a jármű már belépet!");
                        }
                        else
                        {
                            bent.Add(rendszam, "autó");
                            string ido = DateTime.Now.ToString();
                            File.AppendAllText(fajl, $"Rendszám: {rendszam} | Belépési idő: {ido}\n");
                            Console.WriteLine("Autó belépése sikeresen rögzítve!");
                        }
                    }    
                }
                else if (tipus == "motor")
                {
                    Console.Write("Add meg a rendszámát a motornak: ");
                    string rendszammotor = Console.ReadLine();

                    if (rendszammotor == "")
                    {
                        Console.WriteLine("Nem adott meg rendszámot!");
                        continue;
                    }

                    else
                    {
                        
                        if (bent.ContainsKey(rendszammotor))
                        {
                        Console.WriteLine("Ez a jármű már belépet!");
                        }
                        else
                        {
                            bent.Add(rendszammotor, "motor");
                            string ido = DateTime.Now.ToString();
                            File.AppendAllText(fajl, $"Rendszám: {rendszammotor} | Belépési idő: {ido}\n");
                            Console.WriteLine("Motor belépése sikeresen rögzítve!");
                        } 
                    }
                }

                else
                {
                    Console.Write("Adja meg a nevét: ");
                    string nev = Console.ReadLine();
                    Console.Write("Adja meg az igazolványszámát: ");
                    string iszam = Console.ReadLine();
                    if(nev == "")
                    {
                        Console.WriteLine("Nem adott meg nevet!");
                        continue;
                    }
                    else
                    {
                        if (bent.ContainsKey(nev))
                        {
                            Console.WriteLine("Már létezik ilyen nevű felhasználó!");
                        }

                        else
                        {
                            bent.Add(nev, iszam);
                            string ido = DateTime.Now.ToString();
                            File.AppendAllText(fajl, $"Név: {nev} | Igazolványszám: {iszam}\n");
                            Console.WriteLine("Belépés sikeresen rögzítve!");
                        }
                    }    
                }
            }

            else if (gomb == "2")
            {
                Console.Write("Adja meg a távozó azonosítóját (név vagy rendszám): ");
                string tavozas = Console.ReadLine();

                if(tavozas == "")
                {
                    Console.WriteLine("Nem adott meg azonosítót!");
                    continue;
                }
                else{

                    if (bent.ContainsKey(tavozas))
                    {
                        string reszlet = bent[tavozas];
                        string tavozasiido = DateTime.Now.ToString();

                        File.AppendAllText(fajl, $"{tavozas}, (Azonosító/igazolványszám: {reszlet} | Távozott: {tavozasiido})");
                        bent.Remove(tavozas);
                        Console.WriteLine("A távozást sikeresen rögzítettük!");
                    }

                    else
                    {
                        Console.WriteLine("Nincs ilyen azonosító a bent lévők között!");
                    }
                }
            }

            else if (gomb == "3")
            {
                Console.Write("Adja meg kit keres: ");
                string keresett = Console.ReadLine();

                string szoveg = File.ReadAllText(fajl);
                string[] sorok = szoveg.Split('\n');
                
                if (keresett == "")
                {
                    Console.WriteLine("Nem adott meg keresett azonosítót!");
                    continue;
                }

                else
                {

                    foreach (string s in sorok)
                    {

                        if (s.Contains(keresett) && s.Contains("Belépési idő: "))
                        {
                            Console.WriteLine(s);
                        }
                        else
                        {
                            Console.WriteLine("Ilyen adat nincs");
                        }
                    }
                }    
            }   

            else
            {
                Console.WriteLine("Nincs ilyen gomb, 1 és 4 között próbálja!");

            }

        }
    }
}

