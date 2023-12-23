// 6/16 cases with success - the current code exceed the time limit

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    
        int tests = Convert.ToInt32(Console.ReadLine());
        
        var stack = new Stack<int>();
        var stackaux = new Stack<int>();
        
        for (int index = 0; index < tests; index++) {    
            var command = Console.ReadLine();
            
            var commandArray = Array.ConvertAll(command.Split(" "), e => int.Parse(e));
            
            if (commandArray[0] == 1)
                {
                    var stackCount = stack.Count;

                    for (int j = 0; j < stackCount; j++)
                        stackaux.Push(stack.Pop());

                    stack.Push(commandArray[1]);

                    var stackauxCount = stackaux.Count;

                    for (int j = 0; j < stackauxCount; j++)
                        stack.Push(stackaux.Pop());

                }
            
            if (commandArray[0] == 2)
            {
                stack.Pop();
            }
            
            if (commandArray[0] == 3)
            {
                Console.WriteLine(stack.Peek());
            }
        }
    }
}
