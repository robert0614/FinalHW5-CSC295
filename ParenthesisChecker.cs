using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW5
{
    public class ParenthesisChecker
    {
        public static bool isBalanced(string expression)
        {
            Stack stack = new Stack();
            
            foreach (char c in expression)
            {
                // Push opening brackets onto the stack.
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // For closing brackets, check if they match the top of the stack.
                else if (c == ')' || c == '}' || c == ']')
                {
                    // If the stack is empty, there is no matching opening bracket.
                    if (stack.Count == 0)
                    {
                        return false;   // Unmatched closing bracket found
                    }

                    // Pop the last opening bracket from the stack.
                    char last = (char)stack.Pop()!;

                    // Check if the current closing bracket matches the last opening bracket.
                    if ((c == ')' && last != '(') || (c == '}' && last != '{') || (c == ']' && last != '['))
                    {
                        return false; // Mismatched parentheses
                    }
                }
            }

            // After processing all characters, the stack should be empty if all brackets were matched.
            return stack.Count == 0; // True if no unmatched opening brackets remain
        }
    }
}
