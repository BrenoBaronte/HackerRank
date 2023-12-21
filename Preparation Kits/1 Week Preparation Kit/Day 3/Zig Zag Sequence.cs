public class Solution {
    // This challenge is broken for C# in HackerRank https://www.hackerrank.com/challenges/one-week-preparation-kit-zig-zag-sequence/forum/comments/1367621
    public int[] ZigZagSequence(int[] a, int n)
        {
            // Adapted C# code solution from https://www.hackerrank.com/challenges/one-week-preparation-kit-zig-zag-sequence/forum/comments/1368818

            Array.Sort(a);
            
            int mid = ((n + 1) / 2) - 1;

            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st++;
                ed--;
            }

            return a;
        }
}