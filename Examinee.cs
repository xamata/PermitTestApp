using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermitTestApp
{
    internal class Examinee
    {
        public string Name;
        public int Score;
        public Examinee(string examineeName)
        {
            Name = examineeName;
            Score = 0;
        }
    }
}
