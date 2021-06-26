using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class testCases
    {
        public Tuple<int, List<List<int>>> GetTestCases()
        {
            try
            {
                using (StreamReader sr = new StreamReader(AppContext.BaseDirectory + "\\testCasesFile.txt"))
                {
                    string ln = sr.ReadLine();

                    int arrLength = Convert.ToInt32(ln.Split(' ')[0]);

                    List<List<int>> queries = new List<List<int>>();
                    int[] query=new int[3];

                    while (!sr.EndOfStream)
                    {
                        ln = sr.ReadLine();

                        var elements = ln.Split(' ');

                        query[0] = Convert.ToInt32(elements[0]);
                        query[1] = Convert.ToInt32(elements[1]);
                        query[2] = Convert.ToInt32(elements[2]);

                        queries.Add(query.ToList());
                    }

                    return new Tuple<int, List<List<int>>>(arrLength, queries);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<int> GetBribeTestCases()
        {
            try
            {
                using (StreamReader sr = new StreamReader(AppContext.BaseDirectory + "\\testCasesFile1.txt"))
                {
                    //List<int> res = new List<int>();

                    var n = sr.ReadLine().Trim();
                   n = sr.ReadLine().Trim();

                    return sr.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
