using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    void Start()
    {
        islem(1, 20);
    }
    void islem(int sayi1, int sayi2)
    {
        List<int> liste1 = new List<int>();
        for (int i = sayi1; i <= sayi2; i++)
        {
            liste1.Add(i);

        }
        string liste1Str = "SAYILAR -->>";
        string liste2Str = "2 NİN KATLARI -->> ";
        string liste3Str = "3 ÜN KATI SAYILAR -->> ";
        string liste4Str = "4 ÜN KATI SAYILAR -->> ";
        string liste5Str = "5 İN KATI SAYILAR -->> ";
        foreach (int i in liste1)
        {
            liste1Str += "" + i.ToString() + " - ";
            if (i % 2 == 0) liste2Str += "" + i.ToString() + " - ";
            if (i % 3 == 0) liste3Str += "" + i.ToString() + " - ";
            if (i % 4 == 0) liste4Str += "" + i.ToString() + " - ";
            if (i % 5 == 0) liste5Str += "" + i.ToString() + " - ";
        }
        Debug.Log(liste1Str);
        Debug.Log(liste2Str);
        Debug.Log(liste3Str);
        Debug.Log(liste4Str);
        Debug.Log(liste5Str);
    }
}
