using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB3DMOVE : MonoBehaviour
{
    
    public float speed = 100f; 
    public Rigidbody rb; 
    public Vector3 movement; 



    void Start()
    {
        
        rb = this.GetComponent<Rigidbody>();
    }



    
    void Update()
    {

        movement = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
    }



    void FixedUpdate()
    {
        moveCharacter(movement); 
    }



    void moveCharacter(Vector3 direction)
    {
      
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }

}
