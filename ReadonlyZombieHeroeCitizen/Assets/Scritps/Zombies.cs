using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombies : MonoBehaviour
{
    public enum State
    {
        idle,
        move,
        rotating
    }
    public State state;


    public static Color[] zCol;
    public static string[] zTaste;
    public DataZombies zombie=new DataZombies();
    

    private void Awake()
    {
        zCol = new Color[3] //registro de colores
        {
            Color.cyan,
            Color.magenta,
            Color.green
        };

        zTaste = new string[5]
        {
            "intestino grueso",
            "hipotálamo",
            "asterisco",
            "higado canceroso",
            "pelo de hipster"
        };
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public static void ZombMove(GameObject zombie, State s)
    {
        switch (s)
        {
            case State.idle:
                break;
            case State.move:
                float dir = zombie.GetComponent<Zombies>().zombie.rotY;
                zombie.transform.position += zombie.transform.forward / 10;
                zombie.transform.rotation = Quaternion.Euler(0,dir,0);
                break;
            case State.rotating:
                float rot = zombie.GetComponent<Zombies>().zombie.rotY;
                zombie.transform.rotation = Quaternion.Euler(0, rot, 0);
                break;
            default:
                break;
        }
    }
}

public struct DataZombies
{
    public Color col;
    public string taste;
    public float rotY;
}


