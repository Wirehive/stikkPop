using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stikkPop.Properties;

namespace stikkPop
{
    public static class Startup
    {
        public static List<String> syntaxList = new List<String>();

        public static void loadSyntax()
        {
            string[] syntaxs = Settings.Default["availableSyntax"].ToString().Replace(" ", "").Split(',');
            foreach (string syntax in syntaxs)
            {
                syntaxList.Add(syntax);
            }
        }
    }
}
