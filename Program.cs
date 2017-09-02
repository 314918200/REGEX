using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "sakjfgldskajfk     sfasd gdsfhg   fghdsh    ghfghfa siaewri df   gdsfgksdlfgk          ldskgsl  ld   glfdkg   lfkdsgjlfs ll  lk  j jdj  glskg   ;fglhs h ssgs ;sk j  ";
            string[] gg =ss.Split(new char[] { },StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in gg)
            {
                Console.WriteLine(item);
                Console.WriteLine("****************************************");
                Console.ReadKey();
            }
        }
    }
}
