// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenghitungVolumeBola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pendeklarasian Variabel
            /*
             phi variabel dari 3.14 atau 22/7
             r variabel dari jari-jari
             v variabel dari volume
             */
            double phi, r, v;
            phi = 3.14;
            char u;

            do
            {
                Console.Clear();
                //Judul Program
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                 PROGRAM PENGHITUNG VOLUME BOLA                ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                          Created By:                          ||");
                Console.WriteLine(" ||                 https://idekevin.blogspot.com                 ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                       CARA MENGGUNAKAN :                      ||");
                Console.WriteLine(" ||             Tekan enter, setelah memasukkan input!            ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine();
                Console.WriteLine(" ___________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine();

                //Program Penghitung Volume Bola
                Console.Write(" Silahkan masukkan jari-jari (r) Bola (cm): ");
                r = double.Parse(Console.ReadLine());
                v = (3.14) * r * r * r * 4 / 3;
                Console.WriteLine("       Hasilnya, besar volume bola adalah : {0} cm", v);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Penjelasan :");
                Console.WriteLine();
                Console.WriteLine(" Rumus Volume Bola adalah V = 4/3 . 3,14 . r³");
                Console.WriteLine(" Kita ketahui bahwasannya jari-jari bola adalah {0} cm", r);
                Console.WriteLine(" Sehingga kita bisa mensubstitusikan ke dalam rumus sebagai berikut :");
                Console.WriteLine();
                Console.WriteLine(" V = 4/3 . Phi . r³");
                Console.WriteLine("   = 4/3 . {0} . {1}³", phi, r);
                Console.WriteLine();
                Console.WriteLine(" Jadi, volume bola adalah {0} cm", v);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Ingin Menghitung Lagi? (y/t)");
                Console.Write(" Jawab : ");
                u = char.Parse(Console.ReadLine());
            }
            while (u == 'y' | u == 'Y');

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" TIPS :");
                Console.WriteLine(" Berlatih soal-soal secara rutin, akan membantumu");
                Console.WriteLine(" mengusai Matematika.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------- Selamat Belajar! ------------------------");
                Console.WriteLine(" -------------------- Matematika itu Menyenangkan ------------------");
                Console.WriteLine(" - Jangan mudah menyerah, karena usaha tidak akan menghianati hasil-");
                Console.ReadLine();
                Console.Clear();
            }
            while (u == 't' | u == 'T');
            Console.ReadLine();
            Console.Clear();
        }
    }
}