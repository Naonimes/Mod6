using System;

namespace TP_MODUL6_NIM
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            
            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
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