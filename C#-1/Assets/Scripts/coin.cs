using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int point =0;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    
     void OnTriggerEnter(Collider other)
    {
     if(other.name== "Capsule")
     {
        point++;
        Destroy(gameObject);
	 }
	}
    
}    

