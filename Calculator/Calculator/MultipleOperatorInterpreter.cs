using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Calculator
{
    class MultipleOperatorInterpreter
    {
        Node CurrentLocation;
        public List<string> StringInterpreter(string equation)
       {
            int x = 1;
            List<string> list = new List<string>() { };
            Regex regex = new Regex(@"(\d*\.?\d*)");
            Regex regex1 = new Regex(@"[*+/-]");
            MatchCollection matches = regex.Matches(equation);
            MatchCollection matches1 = regex1.Matches(equation);
            foreach (Match match in matches)
            {
                list.Add(Convert.ToString(match));
            }
            foreach (Match match in matches1)
            {
                list.Insert(x, Convert.ToString(match));
                x += 3;
            }
            return list;
        }
        //public Node AssembleTree(List<string> equation)
        //{

        //}
        //public Node CreateNode()
        //{

        //}
   }
}
