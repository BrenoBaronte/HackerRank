// https://www.hackerrank.com/challenges/one-week-preparation-kit-queue-using-two-stacks/forum/comments/1313590

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        var enqueueStack = new Stack<int>();
        var dequeueStack = new Stack<int>();

        int commands = int.Parse(Console.ReadLine());
        
        for (int index = 0; index < commands; index++)
        {
            var query = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList();
            
            if (query[0] == 1)
                enqueueStack.Push(query[1]);
                
            if (query[0] == 2)
            {
                if (dequeueStack.Count == 0) 
                    while (enqueueStack.Count > 0) 
                        dequeueStack.Push(enqueueStack.Pop());
                        
                dequeueStack.Pop();
            }
            
            if (query[0] == 3)
            {
                if (dequeueStack.Count == 0) 
                    while (enqueueStack.Count > 0) 
                        dequeueStack.Push(enqueueStack.Pop());
                        
                Console.WriteLine(dequeueStack.Peek());
            }
        }
    }
}
