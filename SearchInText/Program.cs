using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchInText
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string inputpath = "D:\\SolutionsForSpaceApp\\2042\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2042\\output.txt";

            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();



            string s;
            using (StreamReader reader = new StreamReader(inputpath))
            {
                s = reader.ReadLine();
            }


                

            List<string> list = new List<string>();
            string xml = "";
            int i = 0;
            for (; i < s.Length;)
            {
                if (s[i + 1] != '/')
                {
                    xml = s.Substring(i, 3);
                    i += 3;
                }
                else
                {
                    xml = s.Substring(i, 4);
                    i += 4;
                }
                list.Add(xml);
            }

            int t = 0;
            i = 0;
            string outputString = "";
            while (i < list.Count)
            {
                if (i > 0 && (list[i][2] == list[i - 1][1]))
                {
                    t--;
                    outputString += (String.Concat(Enumerable.Repeat(" ", t * 2)) + list[i]);
                    list.RemoveAt(i);
                    list.RemoveAt(i - 1);
                    i--;
                }
                else
                {
                    outputString += (String.Concat(Enumerable.Repeat(" ", t * 2)) + list[i]);
                    t++;
                    i++;
                }
            }

        }
    }
}
