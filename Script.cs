using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{// Start is called before the first frame update
    void Start()
    {
        //typ_zmiennej nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 20;
        Debug.Log(b);
        {
            //skakanie
            Debug.Log(b);
        }
        { //chodzenie
            int c = 20;
        }
        float fa = 1.5f;
        //float do 7 miejsca po przecinku
        fa = 20.0f;
        bool logiczna = true; //lub false
        string str = "jakiś napis";
        Debug.Log("fa: "+ fa + " logiczna: " + logiczna +" str: "+str);
        //operacje na zmiennych + - * /
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

        // if (warunek_logiczny)
        // {
        // }

        if (a == b)
        {
            Debug.Log("Tak jest taka saama!");
            Koniunkcja(a, b);
        }
        else if (a<b)
        {
            Debug.Log("a < b");
            Alternatywa();
        
        }
        else
        {
            Koniunkcja(a, b);
            Alternatywa();
            Debug.Log("żadne z powyższych");
        }
        Koniunkcja(a, b);
        Alternatywa();
       
    }
    public void Koniunkcja(int a, int b)
    {
        Debug.Log((a != b) && (a > 0));
        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }
        if ((a != b) && (a > 0))
        {
            //kod
        }

    }
    public void Alternatywa() {
        //brzydka wersja 
        int hp = 2, time = 1;
        bool amulet = true;
        if (hp <= 0)
        {
            if (!amulet)
            {
                //sprawdzamy czy amulet == false
            }
            else
            {
                //
            }
        }
        if (time <= 0)
        {
            if (!amulet)
            { //sprawddzamy czy amulet ==false
            }
            else
            {
            }
        }
        //ładna wersja
        if ((hp <= 0) || (time <= 0))
        {
            if (!amulet)
            {
                //sprawdzamy czy amulet == false

            }
            else
            {
                //
            }
        }
    }
    
    void Update()
    {
        
    }

}
