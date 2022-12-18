using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Demonstrera grunder i C#. 
/// 
/// Inneh�ll:
/// utskrift till konsoll
/// if-sats
/// inl�sning fr�n tangentbord
/// while-slinga
/// for-slinga
/// vektor (eng. array)
/// klassen List
/// foreach-slinga
/// metodanrop
/// metoddefinition
/// 
/// Version: 2022-12-18
/// Author: Rikard Karlsson
/// </summary>

public class Demonstration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //RunHello();
        //RunVariable();
        RunIf();
        /*
        RunIfElse();
        RunWhileWithCounter();
        RunFor();
        RunWhileWithoutCounter();
        RunArrayAndForEach();
        RunListForEach();
        RunCallMethod();
        */
    }

    // att l�ra: skriva ut text
    // ---------------------------
    void RunHello()
    {
        Debug.Log("Hello");
    }

    // att l�ra: varaibler
    // --------------------
    // datatyp variabelnamn;
    // variabelnamn = v�rde;
    //
    // viktigaste datatyperna:
    // int - heltal
    // double - decimaltal
    // String eller string - text
    // char - en bokstav
    // bool - true, false
    void RunVariable()
    {
        // rektangel
        double bredd = 20;
        double h�jd = 30;
        double area;
        area = bredd * h�jd;
        Debug.Log("rektangel");
        Debug.Log("bredd: " + bredd);
        Debug.Log("h�jd: " + h�jd);
        Debug.Log("area: " + area);

    }


    // att l�ra: if-sats
    // ----------------------
    void RunIf()
    {
        // kasta t�rning - du beh�ver inte f�rst� n�sta kodrad nu
        System.Random randomGenerator = new System.Random();
        int antalT�rnings�gon = randomGenerator.Next(1, 7);
        
        // bygg text att skriva ut
        string output = "Det kostar en krona att spela t�rning. Sexor ger vinst.\n"; // \n ger ny rad i utskrift
        output += "T�rningen visar: " + antalT�rnings�gon + "\n";

        if (antalT�rnings�gon == 6)
        {
            output += "Grattis du vann 5kr.\n";
        }
        else
        {
            output += "F�rlust.\n";
        }
        Debug.Log(output);
    }

    void RunIfElse()
    {
        // kasta t�rning - du beh�ver inte f�rst� n�sta kodrad nu
        System.Random randomGenerator = new System.Random();
        int antalT�rnings�gon = randomGenerator.Next(1, 7);
        // att l�ra: if med else if
        // ---------------------------
        // kasta t�rning - du beh�ver inte f�rst� n�sta kodrad nu
        antalT�rnings�gon = randomGenerator.Next(1, 7);

        Debug.Log("Det kostar en krona att spela t�rning.");
        Debug.Log("Sexor ger storvinst och ettor tr�stpris.");
        Debug.Log("T�rningen visar: " + antalT�rnings�gon);

        if (antalT�rnings�gon == 6)
        {
            Debug.Log("Grattis du vann 4kr.");
        }
        else if (antalT�rnings�gon == 1)
        {
            Debug.Log("Grattis du vann 1kr.");
        }
        else
        {
            Debug.Log("F�rlust.");
        }


    }

    // att l�ra: while med r�kare
    // --------------------
    void RunWhileWithCounter()
    {
        int r�knare = 0;
        while (r�knare < 5)
        {
            Debug.Log("" + r�knare);
            r�knare = r�knare + 1;
        }

    }

    // att l�ra: for-slinga
    // -----------------------
    // Ger samma utskrift som while-slingan ovan.
    public void RunFor()
    {
        // ofta d�ps variabeln till i ist�llet f�r r�knare
        for (int r�knare = 0; r�knare < 5; r�knare = r�knare + 1)
        {
            Debug.Log("" + r�knare);
        }
    }


    // att l�ra: while utan r�knare
    // -----------------------------
    public void RunWhileWithoutCounter()
    {
        String input = "j";
        while (input.Equals("j")) // eller while ( input == "j")
        {
            Debug.Log("G�r n�got viktigt! ...");
            Debug.Log("Vill du forts�tta? j/n");
            input = "n";// Console.ReadLine();
        }
        Debug.Log("Klart!");

    }


    // att l�ra: vektorer (eng. array)
    // -------------------------------
    // Kallas f�r f�lt av vissa f�rfattare.
    void RunArrayAndForEach()
    {
        String[] lista = { "mj�lk", "ost", "br�d" };
        Debug.Log(lista[0]);
        Debug.Log(lista[1]);
        Debug.Log(lista[2]);


        int[] tal = new int[5];
        tal[0] = 4;
        tal[1] = 1;
        tal[2] = 3;
        tal[3] = 4;
        tal[4] = 6;



        // Att l�ra: foreach-slinga
        // ------------------------
        string output = "";
        foreach (int talet in tal)
        {
            output += (talet + ", ");
        }
        Debug.Log(output);

    }
    // att l�ra: klassen List
    // Anv�nd den ist�llet f�r array, se ovan.
    // Bra att k�nna till array om den finns i f�rdig kod.
    // -------------------------------

    void RunListForEach()
    {
        List<String> lista = new List<String>();
        lista.Add("mj�lk");
        lista.Add("ost");
        lista.Add("br�d");

        // Att l�ra: foreach-slinga
        // ------------------------
        string output = "";
        foreach (string vara in lista)
        {
            output += (vara + ", ");
        }
        Debug.Log(output);
    }





    // Att l�ra: anropa metoder
    // ------------------------

    void RunCallMethod()
    {
        // anrop av metoden printHello
        // metoden finns definierad l�ngre ner
        printHello();

        // Att l�ra:
        // anrop av metoden print som tar en parameter
        // Texten som ska skrivas ut skickas med, som en s� kallad parameter.
        // Metoden print finns definierad l�ngre ner
        // ----------------------
        print("Anrop av metoden print.");
        print("");

        int x = 0;
        // skriv ut text
        Debug.Log("x f(x) = 2x + 1");
        while (x < 6)
        {
            // Att l�ra:
            // anropa metoden f som tar en parameter och ger ett svar
            // ----------------------
            double svar = f(x);
            Debug.Log(x + " " + svar);
            x = x + 1;
        }



    }

    // Att l�ra: definera metod
    // ---------------------------
    // Det som st�r i metoden g�rs n�r den anropas
    // private void printHello() kallas metodhuvud
    private void printHello()
    {
        // inneh�llet i metoden kallas f�r metodkropp
        Debug.Log("Hej och v�lkommen till C#.");

    }

    // Att l�ra: definiera metod som tar parameter.
    // --------------------------------------------
    // Texten som m�ste skickas med vid anropet kallas parameter.
    private void print(String text)
    {
        Debug.Log(text);
    }

    // Att l�ra: definiera metoder med returv�rde och parameter
    // --------------------------------------------------------
    // Svaret som l�mnas tillbaka kallas f�r returv�rde.
    private double f(double value)
    {
        return 2 * value + 1;
        // eller byt raden ovan mot:
        // double svar = 2 * value + 1;
        // return svar;
    }


}
