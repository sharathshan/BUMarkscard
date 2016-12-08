using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuMarkscard.Core;

namespace BUMarkscard
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"D:\Att\Source\2SEM_CREDIT_BASED_mc_data1.zip";
            string DestPath = @"D:\Att\Dest\";
            Stopwatch sw = new Stopwatch();

            sw.Start();
            ImportData.Extractdata(FilePath, DestPath);
            sw.Stop();
            Console.WriteLine("HH:{0} / MM {1} / SS {2} / MS {3}", sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);
        }
    }
}
