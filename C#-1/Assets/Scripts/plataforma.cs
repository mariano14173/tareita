using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public float velocidad;
    int i=1;
    public GameObject inf,sup;


    void FixedUpdate()
    {
        if(i==1){
        transform.position = (Vector3.MoveTowards(transform.position,inf.transform.position,velocidad*Time.fixedDeltaTime));
		}
        if(i==-1){
        transform.position = (Vector3.MoveTowards(transform.position,sup.transform.position,velocidad*Time.fixedDeltaTime));
		}
        if(transform.position==sup.transform.position){
            i=1;  
		}
        else if(transform.position==inf.transform.position) i=-1;
	}	
      
	
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player"))
        {
         collision.transform.parent=transform;
	    }
	}
    
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player"))
        {
         collision.transform.parent=null;
	    }
    }
}  
       

        
     

