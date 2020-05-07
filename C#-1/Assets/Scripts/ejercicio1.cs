using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    Rigidbody rbd;
    Transform tran;
    void Start()
    {
     float velocidad=10
     ; 
        Vector3 direccion = new Vector3(0, 0, 1);

       Vector3 Vel=direccion.normalized*velocidad;

        //INSTANCIAR
        tran = gameObject.GetComponent<Transform>();
        rbd = gameObject.GetComponent<Rigidbody>();
        rbd.velocity = Vel;
    }
    void FixedUp(){
    }

  
}
