using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuMarkscard.Core
{
    public enum BatchType
    {
        CORRECTION
          , REGULAR

    }
    public class Batch
    {
        public int BatchId { get; set; }
        public BatchType BatchType { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime ImportedDate { get; set; }
    }
}
