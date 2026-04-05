using System;

namespace TP_MODUL6_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("=== UJI NORMAL ===");
            SayaMusicTrack track1 = new SayaMusicTrack("Lagu Normal");
            track1.IncreasePlayCount(1000000); // 1 Juta (Di bawah 10 juta)
            track1.PrintTrackDetails();

            
            Console.WriteLine("=== UJI EXCEPTION (OVERFLOW) ===");
            SayaMusicTrack track2 = new SayaMusicTrack("Lagu Overflow");

           
            for (int i = 0; i < 216; i++)
            {
                track2.IncreasePlayCount(10000000);
            }
            track2.PrintTrackDetails();

            
        }
    }
}