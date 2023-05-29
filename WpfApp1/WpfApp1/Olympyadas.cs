using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Olympyada
    {
        public static string StudentScore;
        public static string StudentName;
        public static string StudentFamily;

        public Olympyada(string Score, string Name, string Family)
        {
            StudentScore = Score;
            StudentName = Name;
            StudentFamily = Family;
        }
    }
}
