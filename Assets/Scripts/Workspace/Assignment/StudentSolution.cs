using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            return (count, popped, peek, stack.Count);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            return (count, dequeued, peek, queue.Count);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            List<string> names = new List<string>();
            while (stack.Count > 0)
            {
                names.Add(stack.Pop().Name);
            }
            return names.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            List<string> names = new List<string>();
            while (queue.Count > 0)
            {
                names.Add(queue.Dequeue().Name);
            }
            return names.ToArray();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char letter in str)
            {
                stack.Push(letter);
            }

            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }
            return reversed;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            string reversed = ASN01_ReverseString(str);
            return str == reversed;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char bracket in str)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    stack.Push(bracket);
                }
                else if (bracket == ')' || bracket == ']' || bracket == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char opening = stack.Pop();
                    if ((bracket == ')' && opening != '(') ||
                        (bracket == ']' && opening != '[') ||
                        (bracket == '}' && opening != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        #endregion
    }
}
