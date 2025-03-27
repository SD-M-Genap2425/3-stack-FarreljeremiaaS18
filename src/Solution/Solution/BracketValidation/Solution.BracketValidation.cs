using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data;
            public Node Next;

            public Node(char data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top; 

        public BracketValidator()
        {
            top = null;
        }

        
        private void Push(char item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
        }

        
        private char Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack kosong");

            char item = top.Data;
            top = top.Next;
            return item;
        }

       
        private bool IsEmpty()
        {
            return top == null;
        }

        
        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch); 
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (IsEmpty())
                        return false;

                    char topChar = Pop();
                    if (!IsMatch(topChar, ch)) 
                        return false;
                }
            }

            return IsEmpty(); 
        }

        private bool IsMatch(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
