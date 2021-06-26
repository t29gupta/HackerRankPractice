using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CyclicRotateArray();

            //MissingElement(new int[] { 1, 2, 3, 4, 5, 7, 8, 9 });
            //maxPathMatrix(new int[][] {
            //   new int[] { 9,9,7},
            //   new int[] { 9,7,2},
            //   new int[] { 6,9,5},
            //   new int[] { 9,1,2}
            //    });

            //maxsolution("50552");

            //DelegateExaple delegateExaple = new DelegateExaple();

            //var d = formatPhonenumber("00-44   48  555 8361");
            //var f = formatPhonenumber("0 - 22 1985--324");

            //var d = VacationCalculator(2014, "April", "May", "Wednesday");

            //var ds = GraphPath(4,new int[] { 1, 2, 4, 4, 3 },new int[] { 2, 3, 1, 3, 1 });
            //var ds = GraphPath(4, new int[] { 1, 2, 1, 3 }, new int[] { 2, 4, 3, 4 });

            //var s = GetDominoChain("6-3");
            //Console.WriteLine(s);
            //s = GetDominoChain("1-2,1-2");
            //Console.WriteLine(s);
            //s = GetDominoChain("1-1,3-5,5-2,2-3,2-4");
            //Console.WriteLine(s);
            //s = GetDominoChain("3-2,2-1,1-4,4-4,5-4,4-2,2-1");
            //Console.WriteLine(s);
            //s = GetDominoChain("5-5,5-5,4-4,5-5,5-5,5-5,5-5,5-5,5-5,5-5");
            //Console.WriteLine(s);
            //s = GetDominoChain("1-2,2-2,3-3,3-4,4-5,1-1,1-2");
            //Console.WriteLine(s);

            //var a = jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 });

            //var s = RemoveDuplicates(new int[] {  });

            //var s = LengthOfLongestSubstring("dvdf");
            //s = LengthOfLongestSubstring("pwwkew");
            //s = LengthOfLongestSubstring("aasfdsfweas");

            //rotLeft((new int[] { 1, 2, 3, 4, 5 }).ToList(), 4);
            //minimumBribes((new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }).ToList());
            //minimumSwaps((new int[] { 1, 3, 5, 2, 4, 6, 7 }));

            //int[] qur1 = new int[] { 1, 2, 100 };
            //int[] qur2 = new int[] { 2, 5, 100 };
            //int[] qur3 = new int[] { 3, 4, 100 };

            //List<List<int>> queries = new List<List<int>>();
            //queries.Add(qur1.ToList());
            //queries.Add(qur2.ToList());
            //queries.Add(qur3.ToList());

            //var ts = new testCases().GetTestCases();

            //arrayManipulation(ts.Item1, ts.Item2);

            //textEditer();
            //var ts = new testCases().GetBribeTestCases();
            //minimumBribes(ts);

            Console.Read();
        }

        public static void textEditer()
        {
            try
            {

                int opCount = Convert.ToInt32(Console.ReadLine());

                StringBuilder currentText = new StringBuilder();
                StringBuilder res = new StringBuilder();
                Stack<string> opsPerformed = new Stack<string>();

                for (int i = 0; i < opCount; i++)
                {
                    var op = Console.ReadLine();

                    //perform operations
                    switch (op[0])
                    {
                        case '1':
                            opsPerformed.Push(currentText.ToString());
                            currentText.Append(op.Split(' ')[1]);
                            break;
                        case '2':
                            opsPerformed.Push(currentText.ToString());
                            int charCount = Convert.ToInt32(op.Split(' ')[1]);

                            if (charCount < currentText.Length)
                            {
                                currentText.Remove(currentText.Length - charCount, charCount);
                            }
                            else
                            {
                                currentText.Clear();
                            }
                            break;
                        case '3':
                            int indx = Convert.ToInt32(op.Split(' ')[1]);
                            if (indx - 1 < currentText.Length)
                            {
                                res.Append(currentText[indx - 1] + "\n");
                            }
                            break;
                        case '4':
                            currentText.Clear();
                            if (opsPerformed.Any())
                            {
                                currentText.Append(opsPerformed.Pop());
                            }
                            break;
                        default:
                            break;
                    }

                }

                Console.WriteLine(res.ToString().Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            int[] res = new int[queries.Count];

            for (int i = 0; i < queries.Count; i++)
            {
                res[i] = strings.Count(x => x == queries[i]);
            }

            return res.ToList();
        }

        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            int[] res = new int[n];

            foreach (var arr in queries)
            {
                res[arr[0] - 1] += arr[2];

                if (arr[1] < n)
                {
                    res[arr[1]] -= arr[2];
                }
            }

            List<long> sums = new List<long>();
            long sum = 0;

            foreach (var item in res)
            {
                if (item < 0)
                {
                    sums.Add(sum);
                }
                sum += item;
            }


            return sums.Any() ? sums.Max() : sum;
        }

        public static int minimumSwaps(int[] arr)
        {
            int iterationCount = 0;
            bool iterate = true;

            while (iterate)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != i + 1)
                    {
                        swap(ref arr[i], ref arr[arr[i] - 1]);
                        iterationCount++;
                        break;
                    }
                    if (i == arr.Length - 1)
                    {
                        iterate = false;
                    }
                }
            }

            return iterationCount;
        }

        static void swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }

        public static void minimumBribes(List<int> q)
        {
            try
            {
                int bribeCount = 0;
                for (int i = 0; i < q.Count; i++)
                {
                    if (q[i] - (i + 1) > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                    else
                    {
                        for (int j = q[i] - 2; j < i; j++)
                        {
                            if (q[j] > q[i])
                            {
                                bribeCount++;
                            }
                        }
                    }
                }
                Console.WriteLine(bribeCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<int> rotLeft(List<int> a, int d)
        {
            try
            {
                if (d == 0 || d == a.Count)
                {
                    return a;
                }

                var res = new List<int>();

                for (int i = 0; i < a.Count; i++)
                {
                    int ind = i + d;

                    if (ind < a.Count)
                    {
                        res.Add(a[ind]);
                    }
                    else
                    {
                        res.Add(a[ind - a.Count]);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            try
            {
                var res = new int[4, 4];
                int maxSum = int.MinValue;

                for (int iRes = 0; iRes < 4; iRes++)
                {
                    for (int jRes = 0; jRes < 4; jRes++)
                    {
                        res[iRes, jRes] = arr[iRes][jRes] + arr[iRes][jRes + 1] + arr[iRes][jRes + 2]
                            + arr[iRes + 1][jRes + 1]
                            + arr[iRes + 2][jRes] + arr[iRes + 2][jRes + 1] + arr[iRes + 2][jRes + 2];
                        maxSum = Math.Max(maxSum, res[iRes, jRes]);
                    }
                }

                return maxSum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            List<string> res = new List<string>(names2.Distinct());

            foreach (var item in names1)
            {
                if (!res.Contains(item))
                {
                    res.Add(item);
                }
            }

            return res.ToArray();
        }

        static public int LengthOfLongestSubstring(string s)
        {
            int res = 0;
            int tempStart = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = tempStart; j < i; j++)
                {
                    if (s[j] == s[i])
                    {
                        res = Math.Max(res, i - tempStart);
                        tempStart = j + 1;
                        break;
                    }
                }

                //if (!temp.ToString().Contains(c))
                //{
                //    temp.Append(c);
                //}
                //else
                //{
                //    if (res < temp.Length)
                //    {
                //        res = temp.Length;
                //    }

                //    string t = temp.ToString();
                //    temp.Clear();
                //    temp.Append(t.Substring(t.IndexOf(c) + 1)+c);
                //}
            }

            return Math.Max(res, s.Length - tempStart);
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                sum += i != k ? bill[i] : 0;
            }

            int ana = sum / 2;
            if (ana == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - ana);
            }
        }

        static public int RemoveElement(int[] nums, int val)
        {
            int u = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[u++] = nums[i];
                }
            }
            for (int i = u; i < nums.Length; i++)
            {
                nums[u] = 0;
            }

            //Array.Resize(ref nums, u + 1);

            return nums.Length;
        }

        static public int RemoveDuplicates(int[] nums)
        {

            int u = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[u])
                {
                    nums[++u] = nums[i];
                }
            }

            Array.Resize(ref nums, u + 1);

            return nums.Length;
        }
        static int jumpingOnClouds(int[] c)
        {
            try
            {
                int jumps = 0;

                for (int i = 0; i < c.Length - 1;)
                {
                    if (i + 2 < c.Length && c[i + 2] == 0)
                    {
                        jumps++;
                        i += 2;
                    }
                    else
                    {
                        jumps++;
                        i++;
                    }
                }

                return jumps;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static int countingValleys(int steps, string path)
        {
            try
            {
                int valleyCount = 0;

                int SeaLeavel = 0;

                foreach (char item in path)
                {
                    if (item == 'D')
                    {
                        SeaLeavel--;
                        if (SeaLeavel == -1)
                        {
                            valleyCount++;
                        }
                    }
                    else
                    {
                        SeaLeavel++;
                    }
                }

                return valleyCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        static int sockMerchant(int n, int[] ar)
        {
            try
            {
                int pairCount = 0;

                var arList = ar.ToList();

                int current_color = arList[0];
                arList.Remove(current_color);

                while (arList.Any())
                {
                    int colorPair = arList.FirstOrDefault(x => x == current_color);

                    if (colorPair > 0)
                    {
                        pairCount++;
                        arList.Remove(colorPair);
                    }

                    current_color = arList[0];
                    arList.Remove(current_color);
                }

                return pairCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static int GetDominoChain(string dominos)
        {
            try
            {
                // Get dominos
                var domninoGrps = dominos.Split(',');

                List<Tuple<int, int>> dominoList = new List<Tuple<int, int>>();

                foreach (var item in domninoGrps)
                {
                    var tempd = item.Split('-');
                    dominoList.Add(new Tuple<int, int>(Convert.ToInt32(tempd[0]), Convert.ToInt32(tempd[1])));
                }

                int i = 1;
                foreach (var item in dominoList)
                {
                    var currentIndex = dominoList.IndexOf(item);
                    var t = dominoList.Where(x => x.Item1 == item.Item2 && dominoList.IndexOf(x) > currentIndex);
                    if (t.Any())
                    {
                        i++;
                    }
                }

                return i == 0 ? 1 : i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static bool GraphPath(int N, int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            for (int i = 1; i <= N; i++)
            {
                if (!A.Contains(i) && !B.Contains(i))
                {
                    return false;
                }
            }

            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();

            for (int i = 0; i < A.Length; i++)
            {
                pairs.Add(new Tuple<int, int>(Math.Min(A[i], B[i]), Math.Max(A[i], B[i])));
            }

            pairs = pairs.OrderBy(x => x.Item1).ToList();

            bool res = true;

            for (int i = 1; i <= N; i++)
            {
                if (pairs.Any(s => s.Item1 == i && s.Item2 == i + 1))
                {
                    continue;
                }
            }

            return false;
        }

        public static int VacationCalculator(int Y, string A, string B, string W)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            try
            {
                int startMonth = DateTime.ParseExact(A, "MMMM", CultureInfo.CurrentCulture).Month;
                int endMonth = DateTime.ParseExact(B, "MMMM", CultureInfo.CurrentCulture).Month;

                DateTime vacStart = new DateTime(Y, startMonth, 1);

                // Getting first monday
                for (int i = 1; i <= 7; i++)
                {
                    if (vacStart.DayOfWeek == DayOfWeek.Monday)
                    {
                        break;
                    }
                    else
                    {
                        vacStart = new DateTime(Y, startMonth, i);
                    }
                }

                int totalDays = DateTime.DaysInMonth(Y, endMonth);
                DateTime vacEnd = new DateTime(Y, endMonth, totalDays); ;

                // Getting first monday
                for (int i = totalDays; i > 0; i--)
                {
                    vacEnd = new DateTime(Y, endMonth, i);

                    if (vacEnd.DayOfWeek == DayOfWeek.Sunday)
                    {
                        break;
                    }
                    else
                    {
                        vacEnd = new DateTime(Y, endMonth, i);
                    }
                }

                var d = (vacEnd - vacStart).Days + 1;

                return d / 7;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static string formatPhonenumber(string S)
        {
            S = S.Replace("-", "").Replace(" ", "");

            string temp = S;
            string res = "";

            while (temp.Length > 0)
            {
                if (temp.Length == 4)
                {
                    res += temp.Substring(0, 2) + "-" + temp.Substring(2, 2);
                    temp = "";
                }
                else if (temp.Length > 3)
                {
                    res += temp.Substring(0, 3) + "-";
                    temp = temp.Remove(0, 3);
                }
                else
                {
                    res += temp;
                    temp = "";
                }
            }

            return res;
        }

        public string phonenumber(string[] A, string[] B, string P)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var filterContactList = new List<string>();

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i].Contains(P))
                {
                    filterContactList.Add(A[i]);
                }
            }

            if (filterContactList.Count() == 0)
            {
                return "NO CONTACT";
            }
            else
            {
                filterContactList = filterContactList.OrderBy(x => x.Count()).ToList();

                return filterContactList[0];
            }
        }

        static int maxsolution(string S)
        {
            List<int> numbers = new List<int>();

            String number = "";
            //bool newNum = true;

            foreach (char num in S)
            {
                if (string.IsNullOrEmpty(number))
                {
                    number += num;
                }
                else
                {
                    number += num;
                    if (number.Length == 2)
                    {
                        numbers.Add(Convert.ToInt32(number));
                        number = "";
                        number += num;
                    }
                }
            }

            Console.WriteLine(numbers.Max());

            return 0;
        }

        static string maxPathMatrix(int[][] A)
        {
            string res = "";

            int height = A.Length;
            int width = A[0].Length;

            int j = 0;

            for (int i = 0; i < A.Length; i++)
            {
                while (j < width)
                {
                    res += A[i][j].ToString();

                    if (j + 1 < width)
                    {
                        if (i + 1 < height)
                        {
                            if (A[i][j + 1] > A[i + 1][j])
                            {
                                j++;
                                continue;
                            }
                            else if (A[i][j + 1] == A[i + 1][j])
                            {
                                // compare 2nd level cells
                                int j2Cell = 0;
                                if (j + 2 < width)
                                {

                                    j2Cell = A[i][j + 2];
                                }

                                int i2cell = 0;
                                if (i + 2 < height)
                                {
                                    i2cell = A[i + 2][j];
                                }

                                j++;
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            j++;
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }


            }


            return res;
        }

        struct neighbours
        {
            public int right { get; set; }
            public int down { get; set; }
            public (int, int) rightCell { get; set; }
            public int j { get; set; }
        }

        /// <summary>
        /// item1 : right | item1 : down
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        Tuple<int, int> GetNeighbours(int[][] arr, int height, int width, int i, int j)
        {
            int rightCell = 0;
            int downCell = 0;
            if (i + 1 < height)
            {
                downCell = arr[i + 1][j];
            }
            if (j + 1 < width)
            {
                rightCell = arr[i][j + 1];
            }

            return new Tuple<int, int>(rightCell, downCell);
        }

        int[] counter(int N, int[] A)
        {
            int[] res = new int[N];

            foreach (var item in A)
            {
                if (item >= 1 && item <= N)
                {
                    res = increaseX(res, item);
                }
                else
                {
                    res = maximiseCounter(res);
                }
            }

            return res;
        }

        int[] increaseX(int[] counterArray, int x)
        {
            counterArray[x - 1]++;
            return counterArray;
        }

        int[] maximiseCounter(int[] counterArray)
        {
            int max = counterArray.Max();

            for (int i = 0; i < counterArray.Length; i++)
            {
                counterArray[i] = max;
            }

            return counterArray;
        }

        public static int MissingElement(int[] A)
        {
            try
            {
                // sum of all elements
                int reqSum = A.Length * (A.Length + 1) / 2;
                int arrSum = A.Aggregate((a, b) => a + b);

                return reqSum - arrSum;
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
            return 0;
        }

        public int BinaryGap(int N)
        {
            // Find the first 1
            int work = N;
            while (work > 0 && (work & 1) == 0)
            {
                Console.WriteLine(Convert.ToString(N, 2));
                work >>= 1;
            }
            work >>= 1;

            int max = 0;
            int zeros = 0;

            while (work > 0)
            {
                if ((work & 1) == 0)
                {
                    zeros++;
                }
                else
                {
                    max = Math.Max(max, zeros);
                    zeros = 0;
                }
                work >>= 1;
            }
            return max;
        }

        private static void CyclicRotateArray()
        {
            //solution(new int[] { 7, 6, 3, 8, 9 }, 5);
            solution1(new int[] { 1, 2, 3, 4 }, 4);
            //solution(new int[] { 5, -1000 }, 0);
            //solution(new int[] { 5, -1000 }, 1);
            //solution(new int[] { 5, -1000 }, 2);
        }

        public static int[] solution1(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            try
            {

                int p = K;
                if (K >= A.Length)
                {
                    p = K % A.Length;
                }

                if (p == 0)
                {
                    return A;
                }

                int[] res = new int[A.Length];


                int d = p == 1 ? 0 : 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i + p - d >= A.Length)
                    {
                        res[i + p - d - A.Length] = A[i];
                    }
                    else
                    {
                        res[i + p - d] = A[i];
                    }
                }


                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return A;
            }
        }
        public static int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            try
            {

                if (K == 0)
                {
                    return A;
                }

                int[] res = new int[A.Length];

                if (K < A.Length)
                {
                    int d = K == 1 ? 0 : 1;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (i + K - d >= A.Length)
                        {
                            res[i] = A[i + K - d - A.Length];
                        }
                        else
                        {
                            res[i] = A[i + K - d];
                        }
                    }
                }
                else
                {
                    int p = K - A.Length;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (i + p >= A.Length)
                        {
                            res[i] = A[i + p - A.Length];
                        }
                        else
                        {
                            res[i] = A[i + p];
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return A;
            }
        }
    }
}
