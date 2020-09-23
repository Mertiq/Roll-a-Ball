using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorTut : MonoBehaviour
{
    static float sayac;
   
    public static void SkorArttir ()
    {
        sayac++;
        if(sayac == 5)
        {
            Debug.Log("bravı");
        }
    }
}
