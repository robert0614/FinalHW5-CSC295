Overview:
The ParenthesisChecker class is a simple yet effective utility for validating the balance of parentheses in a given string expression. This tool is particularly useful in scenarios where you need to ensure that expressions involving parentheses, braces, or brackets are correctly balanced, such as in mathematical formulas or code parsing.

How It Works:
The class uses a stack-based approach to track opening and closing brackets:

Opening Brackets: When an opening bracket ((, {, [) is encountered, it is pushed onto a stack.
Closing Brackets: When a closing bracket (), }, ]) is encountered, the method checks if it matches the most recent opening bracket (popped from the stack). If it doesn't match, or if there is no corresponding opening bracket, the function returns false.
Final Check: After processing the entire expression, the stack should be empty if all brackets were matched correctly. If the stack is not empty, the function returns false.
Usage
This class is ideal for validating expressions in text editors, compilers, or calculators where the correct pairing of parentheses is crucial. It handles all types of brackets and ensures that each pair is properly matched and nested.
