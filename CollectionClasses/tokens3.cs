// tokens.cs
using System;
// The System.Collections namespace is made available:
using System.Collections;

// Declare the Tokens class:
public class Tokens3 : IEnumerable
{
    private string[] elements;

    Tokens3(string source, char[] delimiters)
    {
        // Parse the string into tokens:
        elements = source.Split(delimiters);
    }

    // Test Tokens, TokenEnumerator

    static void Main()
    {
        // Testing Tokens by breaking the string into tokens:
        Tokens3 f = new Tokens3("This is a well-done program. Yes. Yes. Yes.",
           new char[] { ' ', '-' });
        foreach (string item in f)
        {
            Console.WriteLine(item);
        }
    }

    public IEnumerator GetEnumerator()
    {
        return new Tokens3Enumerator(this);
    }

    class Tokens3Enumerator : IEnumerator
    {
        Tokens3 t3;
        int pos;
        public Tokens3Enumerator(Tokens3 t3)
        {
            this.t3 = t3;
            pos = -1;
        }

        public object Current
        {
            get { return t3.elements[pos]; }
        }

        public bool MoveNext()
        {
            if (pos + 1 < t3.elements.Length)
            {
                pos++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }

}
