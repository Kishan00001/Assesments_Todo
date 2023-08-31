using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks
{
    class Hackathon1
    {
        static void Main(string[] args)
        {
            string rule = "the quick and brown fox jumps over the lazy dog";
            string[] val = ValueEncoder(rule);
            Console.WriteLine("Please Enter Your String To be Encoded");
            string query = Console.ReadLine();
            Console.WriteLine(EncodeString(val,query.ToLower()));
        }
        private static string EncodeString(string[] code,string v)
        {
            if (v == null)
                throw new NullReferenceException();
            else if (v == "")
                throw new ArgumentException();
            else
            {
                char[] strChar = v.ToCharArray();
                string ans = "";
                for(int i = 0; i < strChar.Length; i++)
                    if (strChar[i] == ' ')
                        ans += ans.Substring(0, ans.Length - 1)+"-";
                    else
                        ans += (code[strChar[i]-97] + ",");
                ans = ans.Remove(ans.Length - 1);
                return ans;
            }
        }
        private static string[] ValueEncoder(string rule)
        {
            char[] charArr = rule.ToLower().ToCharArray();
            string[] letters = new string[26];
            int word = 0, letter = 0;
            for(int i = 0;i<charArr.Length; i++)
            {  
                if(charArr[i]==' ')
                {
                    word++;
                    letter= 0;
                    continue;
                }
                if(letters[(int)charArr[i] - 97]==null)
                    letters[(int)charArr[i] - 97] = word.ToString() + letter.ToString();
                letter++;
            }
            return letters;
        }
    }
}