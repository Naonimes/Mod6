using System;
using System.Diagnostics;

namespace TP_MODUL6_NIM
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            
            Debug.Assert(title != null, "Judul lagu tidak boleh null!");
            Debug.Assert(title.Length <= 100, "Judul lagu maksimal 100 karakter!");

            this.title = title;
            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            
            Debug.Assert(count <= 10000000, "Input penambahan play count maksimal 10.000.000!");

            try
            {
                
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Penambahan play count menyebabkan overflow (melebihi batas maksimum integer)!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID Track\t: {this.id}");
            Console.WriteLine($"Judul Lagu\t: {this.title}");
            Console.WriteLine($"Play Count\t: {this.playCount}");
            Console.WriteLine("----------------------------------");
        }
    }
}