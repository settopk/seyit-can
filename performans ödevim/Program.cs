using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performans_ödevim
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("oyun dünyasına hoşgeldiniz");
                Console.WriteLine("Lütfen bir oyun seçin");
                Console.WriteLine("seçim 1= taş kağıt makas oyunu");
                Console.WriteLine("seçim 2= sayı tahmın etme oyunu iki kişilik");

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    tas();
                }
                else if (secim == 2)
                {
                    tahmin();
                }


            }


            static void tahmin()
            {
                {
                    Random r = new Random();
                    int[] rasgeleSayi = new int[10];
                    for (int i = 0; i < rasgeleSayi.Length; i++)
                    {
                        rasgeleSayi[i] = r.Next(1, 10);

                    }
                    int puan = 0;
                    int puan2 = 0;


                    for (int i = 0; i < rasgeleSayi.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ".soru");
                        Console.WriteLine("************************");
                        Console.WriteLine("1. oyuncu tahmininizi giriniz");
                        int tahmin1 = Convert.ToInt32(Console.ReadLine());

                        if (tahmin1 == rasgeleSayi[i])//doğru tahmin ihtimali
                        {
                            puan += 10;
                            Console.WriteLine("1. oyuncu puanı " + puan);
                            Console.WriteLine("2. oyuncu puanı " + puan2);
                        }
                        else
                        {
                            if (tahmin1 > rasgeleSayi[i])
                            {

                                puan += 10 - (tahmin1 - rasgeleSayi[i]);
                                Console.WriteLine("1. oyuncu puanı " + puan);
                                Console.WriteLine("2. oyuncu puanı " + puan2);

                            }
                            else
                            {
                                puan += 10 - (rasgeleSayi[i] - tahmin1);
                                Console.WriteLine("1. oyuncu puanı " + puan);
                                Console.WriteLine("2. oyuncu puanı " + puan2);


                            }


                            Console.WriteLine("Lütfen entere basıp devam edin.");
                            Console.Clear();

                            Console.WriteLine("2. oyuncu tahmininizi giriniz");
                            Console.WriteLine("************************");
                            int tahmin2 = Convert.ToInt32(Console.ReadLine());

                            if (tahmin2 == rasgeleSayi[i])
                            {
                                puan2 += 10;
                                Console.WriteLine("1. oyuncu puanı " + puan);
                                Console.WriteLine("2. oyuncu puanı " + puan2);
                            }
                            else
                            {
                                if (tahmin2 > rasgeleSayi[i])
                                {

                                    puan2 += 10 - (tahmin2 - rasgeleSayi[i]);
                                    Console.WriteLine("1. oyuncu puanı " + puan);
                                    Console.WriteLine("2. oyuncu puanı " + puan2);

                                }
                                else
                                {
                                    puan2 += 10 - (rasgeleSayi[i] - tahmin2);
                                    Console.WriteLine("1. oyuncu puanı " + puan);
                                    Console.WriteLine("2. oyuncu puanı " + puan2);

                                }





                                Console.Clear();
                                Console.WriteLine("1. oyuncu puanı: " + puan);
                                Console.WriteLine("2. oyuncu puanı: " + puan2);
                                Console.WriteLine("Lütfen entere basıp devam edin.");

                            }
                            Console.ReadKey();
                        }

                    }
                }
            }
            static void tas()
            {
                {
                    int skor1 = 0;
                    int skor2 = 0;
                    int oyunsuresi = 3;


                    string[] alternatif = new string[3];
                    alternatif[0] = "1";
                    alternatif[1] = "2";
                    alternatif[2] = "3";

                    for (int i = 0; i <= oyunsuresi; i++)
                    {
                        Console.WriteLine("1. oyuncu seçimini yap");
                        Console.WriteLine("1. Taş");
                        Console.WriteLine("2. kağıt");
                        Console.WriteLine("3. makas");

                        string secim1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("2. oyuncu seçimini yap");
                        string secim2 = Console.ReadLine();
                        Console.Clear();


                        if (secim1 == alternatif[0] && secim2 == alternatif[0])//berabere ihtimali
                        {
                            Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }
                        if (secim1 == alternatif[1] || secim2 == alternatif[1])//berabere ihtimali
                        {
                            Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);
                            Console.Clear();
                        }
                        if (secim1 == alternatif[2] || secim2 == alternatif[2])//berabere ihtimali
                        {
                            Console.WriteLine("oyuncular berabere tekrar seçim yapın");
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }


                        if (secim1 == alternatif[1] && secim2 == alternatif[0])//taş kağıt ihtimalleri
                        {
                            Console.WriteLine("1. oyuncu 1 puan aldı.");
                            skor1++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }

                        else if (secim1 == alternatif[0] && secim2 == alternatif[1])//taş kağıt ihtimalleri
                        {
                            Console.WriteLine("2. oyuncu 1 puan aldı.");
                            skor2++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }

                        else if (secim1 == alternatif[2] && secim2 == alternatif[1])//kağıt makas ihtimali
                        {
                            Console.WriteLine("1. oyuncu 1 puan aldı.");
                            skor1++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }

                        else if (secim1 == alternatif[1] && secim2 == alternatif[2])//kağıt makas ihtimali
                        {
                            Console.WriteLine("2. oyuncu 1 puan aldı.");
                            skor2++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }

                        else if (secim1 == alternatif[2] && secim2 == alternatif[0])//makas taş ihtimali
                        {
                            Console.WriteLine("1. oyuncu 1 puan aldı.");
                            skor1++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);

                        }

                        else if (secim1 == alternatif[0] && secim2 == alternatif[2])//makas taş ihtimali
                        {
                            Console.WriteLine("2. oyuncu 1 puan aldı.");
                            skor2++;
                            Console.Clear();
                            Console.WriteLine("1. oyuncu puanı " + skor1);
                            Console.WriteLine("2. oyuncu puanı " + skor2);




                        }


                    }
                    if (skor1 > skor2)
                    {
                        Console.WriteLine("1. oyuncu kazandı");


                    }
                    else
                    {
                        Console.WriteLine("2. oyuncu kazandı");

                    }
                    Console.ReadKey();
                }
            }
        }
    }

