using System;

namespace TP_MODUL6_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track = new SayaMusicTrack("Lagu Indonesia Raya");
            track.IncreasePlayCount(500);
            track.PrintTrackDetails();
        }
    }
}