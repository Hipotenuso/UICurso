using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System;

public static class Util
{
    #if UNITY_EDITOR
    [UnityEditor.MenuItem("CustomMenu/Teste")]  
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("CustomMenu/Teste2 %g")]
    public static void Test2()
    {
        Debug.Log("Test2");
    }
    #endif

    private static System.Random _random = new System.Random();

    public static void GetRandom<T>(this List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

