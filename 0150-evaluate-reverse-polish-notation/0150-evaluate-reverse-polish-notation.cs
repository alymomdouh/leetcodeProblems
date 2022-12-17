/*
using System;
using System.Collections.Generic;
public static class Ext {
    public static void PopAndApply<T>(this IList<T> list, Func<T, T, T> func)
    {
        T a = list[list.Count - 2], b = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        list.RemoveAt(list.Count - 1);
        list.Add(func(a, b));
    }
}
public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new List<int>();
        foreach (string token in tokens) {
            switch (token) {
                case "-":
                    stack.PopAndApply((a, b) => a - b);
                    break;
                case "+":
                    stack.PopAndApply((a, b) => a + b);
                    break;
                case "/":
                    stack.PopAndApply((a, b) => a / b);
                    break;
                case "*":
                    stack.PopAndApply((a, b) => a * b);
                    break;
                default:
                    stack.Add(int.Parse(token));
                    break;
            }
        }
        return stack[0];
    }
}
*/
// the best solution 
using System.Collections.Generic;
public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            switch (token)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    stack.Push(-stack.Pop() + stack.Pop());
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    var right = stack.Pop();
                    stack.Push(stack.Pop() / right);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }
        return stack.Pop();
    }
}