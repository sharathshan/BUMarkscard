using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace BuMarkscard.Core
{
    public class ImportData
    {
        public static void Extractdata(string filePath, string destPath)
        {

            ZipFile.ExtractToDirectory(filePath, destPath);
            FileInfo ImportFile = new FileInfo(filePath);
        }
    }
}
