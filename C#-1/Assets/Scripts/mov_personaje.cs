using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mov_personaje : MonoBehaviour
{
    Rigidbody rbd;
    public float salto;
    float x, z;
    public float velocidad;
    

    void Start()
    {
        rbd = gameObject.GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && rbd.velocity.y == 0)
        {
            rbd.AddForce(new Vector3(0, 1, 0)*salto / Time.fixedDeltaTime);
        }

        z = Input.GetAxis("Horizontal");
        x = Input.GetAxis("Vertical");
        rbd.velocity = new Vector3(x * -velocidad, rbd.velocity.y, z * velocidad);

        
    }
    void OnCollisionEnter(Collision collision){
     if(collision.gameObject.name == "trampolin")
     {
        rbd.velocity = new Vector3(rbd.velocity.x, rbd.velocity.y + 20, rbd.velocity.z);
	 }
	
    
     if(collision.gameObject.name == "Death")
     {
         SceneManager.LoadScene("TAREA");
	 }
    }
   
}