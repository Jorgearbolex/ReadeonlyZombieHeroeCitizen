using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    public sCitizen citizen = new sCitizen();
    public static string[] cNames;

    private void Awake()
    {
        cNames = new string[]
        {
            "Ricardo Montalvant",
            "El charrito negro",
            "Platano",
            "Marzorco",
            "Patricia Nieto",
            "Jean Michel Basquiat",
            "Calvin Klein",
            "Terre",
            "Omaira",
            "Carlos Vives Monda",
            "El simpatico culero",
            "Sacrias piedras del rio",
            "Otto",
            "El herpes de tu alma",
            "Caremimbre",
            "Estabro",
            "Hanna",
            "Ofelia la amargada",
            "Cersar sin  cesar",
            "Uribe el eterno"
        };
        
    }
    
}

public struct sCitizen
{
    public string name;
    public int age;
}