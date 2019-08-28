using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public static Vector3 pos;
    public Color col;
    public static float speed;
    

    void Start()
    {
        speed =  Random.Range(3, 7);
        GetComponent<MeshRenderer>().material.color = col;
    }
    void Update()
    {
        control(pos);
        transform.eulerAngles = new Vector3(0, FPSim.rotY, 0);
        if (Input.GetKey(KeyCode.A)) { transform.position += transform.forward * (speed / 20); }
        if (Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * (speed / 20); }
        if (Input.GetKey(KeyCode.D)) { transform.position += transform.right * (speed / 20); }
        if (Input.GetKey(KeyCode.A)) { transform.position -= transform.right * (speed / 20); }
        pos = transform.position;

    }
    void control (Vector3 p)
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "podrido")
        {
            Debug.Log("Waaaarrrr quiero comer "+ col.gameObject.GetComponent<Zombies>().zombie.taste);
        }
        if (col.gameObject.name == "caremirla")
        {
            Debug.Log("Holandas! soy " + col.gameObject.GetComponent<Citizen>().citizen.name
                + " y tengo " + col.gameObject.GetComponent<Citizen>().citizen.age + " años");
            
        }
    }
}
