using System.Collections.Generic;
using UnityEngine;
using System;

public class ListScript : MonoBehaviour
{

    public List<ListScript> listTest;

    public static void Main()
    {
        List<string> items = new List<string> { "Apple", "Banana", "Orange", "Grape" };
        
        Console.WriteLine("Before GetRandom:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        items.GetRandom();

        Console.WriteLine("\nAfter GetRandom:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    private void Start()
    {
        listTest.GetRandom();
    }
}
