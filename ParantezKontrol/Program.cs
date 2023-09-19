using System;
using System.Collections.Generic;

public class HelloWorld
{
    static bool KontrolEt(string input)
    {
        Stack<char> Stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                Stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (Stack.Count == 0 || !EslesmeKontrol(Stack.Pop(), c))
                {
                    return false;
                }
            }
        }

        return Stack.Count == 0;
    }
    static bool EslesmeKontrol(char acikP, char kapaliP)
    {
        if (acikP == '(' && kapaliP == ')')
        {
            return true;
        }
        if (acikP == '[' && kapaliP == ']')
        {
            return true;
        }
        if (acikP == '{' && kapaliP == '}')
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        Console.WriteLine("ifadeyi girin:");
        string input = Console.ReadLine();

        if (KontrolEt(input))
        {
            Console.WriteLine("Parantezler eşleşiyor");
        }
        else
        {
            Console.WriteLine("Parantezler eşleşmiyor.");
        }
    }
}