using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Demonstrera grunder i C#. 
/// 
/// Innehåll:
/// utskrift till konsoll
/// if-sats
/// inläsning från tangentbord
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

    // att lära: skriva ut text
    // ---------------------------
    void RunHello()
    {
        Debug.Log("Hello");
    }

    // att lära: varaibler
    // --------------------
    // datatyp variabelnamn;
    // variabelnamn = värde;
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
        double höjd = 30;
        double area;
        area = bredd * höjd;
        Debug.Log("rektangel");
        Debug.Log("bredd: " + bredd);
        Debug.Log("höjd: " + höjd);
        Debug.Log("area: " + area);

    }


    // att lära: if-sats
    // ----------------------
    void RunIf()
    {
        // kasta tärning - du behöver inte förstå nästa kodrad nu
        System.Random randomGenerator = new System.Random();
        int antalTärningsögon = randomGenerator.Next(1, 7);
        
        // bygg text att skriva ut
        string output = "Det kostar en krona att spela tärning. Sexor ger vinst.\n"; // \n ger ny rad i utskrift
        output += "Tärningen visar: " + antalTärningsögon + "\n";

        if (antalTärningsögon == 6)
        {
            output += "Grattis du vann 5kr.\n";
        }
        else
        {
            output += "Förlust.\n";
        }
        Debug.Log(output);
    }

    void RunIfElse()
    {
        // kasta tärning - du behöver inte förstå nästa kodrad nu
        System.Random randomGenerator = new System.Random();
        int antalTärningsögon = randomGenerator.Next(1, 7);
        // att lära: if med else if
        // ---------------------------
        // kasta tärning - du behöver inte förstå nästa kodrad nu
        antalTärningsögon = randomGenerator.Next(1, 7);

        Debug.Log("Det kostar en krona att spela tärning.");
        Debug.Log("Sexor ger storvinst och ettor tröstpris.");
        Debug.Log("Tärningen visar: " + antalTärningsögon);

        if (antalTärningsögon == 6)
        {
            Debug.Log("Grattis du vann 4kr.");
        }
        else if (antalTärningsögon == 1)
        {
            Debug.Log("Grattis du vann 1kr.");
        }
        else
        {
            Debug.Log("Förlust.");
        }


    }

    // att lära: while med räkare
    // --------------------
    void RunWhileWithCounter()
    {
        int räknare = 0;
        while (räknare < 5)
        {
            Debug.Log("" + räknare);
            räknare = räknare + 1;
        }

    }

    // att lära: for-slinga
    // -----------------------
    // Ger samma utskrift som while-slingan ovan.
    public void RunFor()
    {
        // ofta döps variabeln till i istället för räknare
        for (int räknare = 0; räknare < 5; räknare = räknare + 1)
        {
            Debug.Log("" + räknare);
        }
    }


    // att lära: while utan räknare
    // -----------------------------
    public void RunWhileWithoutCounter()
    {
        String input = "j";
        while (input.Equals("j")) // eller while ( input == "j")
        {
            Debug.Log("Gör något viktigt! ...");
            Debug.Log("Vill du fortsätta? j/n");
            input = "n";// Console.ReadLine();
        }
        Debug.Log("Klart!");

    }


    // att lära: vektorer (eng. array)
    // -------------------------------
    // Kallas för fält av vissa författare.
    void RunArrayAndForEach()
    {
        String[] lista = { "mjölk", "ost", "bröd" };
        Debug.Log(lista[0]);
        Debug.Log(lista[1]);
        Debug.Log(lista[2]);


        int[] tal = new int[5];
        tal[0] = 4;
        tal[1] = 1;
        tal[2] = 3;
        tal[3] = 4;
        tal[4] = 6;



        // Att lära: foreach-slinga
        // ------------------------
        string output = "";
        foreach (int talet in tal)
        {
            output += (talet + ", ");
        }
        Debug.Log(output);

    }
    // att lära: klassen List
    // Använd den istället för array, se ovan.
    // Bra att känna till array om den finns i färdig kod.
    // -------------------------------

    void RunListForEach()
    {
        List<String> lista = new List<String>();
        lista.Add("mjölk");
        lista.Add("ost");
        lista.Add("bröd");

        // Att lära: foreach-slinga
        // ------------------------
        string output = "";
        foreach (string vara in lista)
        {
            output += (vara + ", ");
        }
        Debug.Log(output);
    }





    // Att lära: anropa metoder
    // ------------------------

    void RunCallMethod()
    {
        // anrop av metoden printHello
        // metoden finns definierad längre ner
        printHello();

        // Att lära:
        // anrop av metoden print som tar en parameter
        // Texten som ska skrivas ut skickas med, som en så kallad parameter.
        // Metoden print finns definierad längre ner
        // ----------------------
        print("Anrop av metoden print.");
        print("");

        int x = 0;
        // skriv ut text
        Debug.Log("x f(x) = 2x + 1");
        while (x < 6)
        {
            // Att lära:
            // anropa metoden f som tar en parameter och ger ett svar
            // ----------------------
            double svar = f(x);
            Debug.Log(x + " " + svar);
            x = x + 1;
        }



    }

    // Att lära: definera metod
    // ---------------------------
    // Det som står i metoden görs när den anropas
    // private void printHello() kallas metodhuvud
    private void printHello()
    {
        // innehållet i metoden kallas för metodkropp
        Debug.Log("Hej och välkommen till C#.");

    }

    // Att lära: definiera metod som tar parameter.
    // --------------------------------------------
    // Texten som måste skickas med vid anropet kallas parameter.
    private void print(String text)
    {
        Debug.Log(text);
    }

    // Att lära: definiera metoder med returvärde och parameter
    // --------------------------------------------------------
    // Svaret som lämnas tillbaka kallas för returvärde.
    private double f(double value)
    {
        return 2 * value + 1;
        // eller byt raden ovan mot:
        // double svar = 2 * value + 1;
        // return svar;
    }


}
