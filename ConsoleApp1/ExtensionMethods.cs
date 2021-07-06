using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractice
{
    public static class ExtensionMethods
    {
        public static int[] testExt(this int[] arr)
        {
            return arr;
        }

        public static ListNode CreateListNode(this int[] arr)
        {
            ListNode temp = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp = new ListNode(arr[i], temp);
            }

            return temp;
        }
    }
}
