using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06.Classes
{
    public class ZNOResult
    {
        public string Subject { get; set; }
        public int Points { get; set; }
        public ZNOResult(string subject, int points)
        {
            Subject = subject;
            Points = points;
        }
    }
}
