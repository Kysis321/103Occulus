using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroMagnet : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform electroPosition;

    public Collider Button;
    public float t;
    Rigidbody cone, torus, sphere;



    // function needed to check if button has been pressed one or twice.
    //public bool HasButtoNBeenPressed()
   // {
        //if button has had its collider entered once - set true, if pressed again toggle false
        //run button on and off scripts as appopriate
    //}
    
    
    
    
    public void ButtonOn()
    {
        //i want to get the rigidbodies of the cone, sohere and torus to move to the designated draw position, then suspend them there - 
        cone.transform.position = Vector3.MoveTowards(electroPosition.position, Vector3.Lerp(cone.position, electroPosition.position, t), Time.deltaTime * 3);
        torus.transform.position = Vector3.MoveTowards(electroPosition.position, Vector3.Lerp(cone.position, electroPosition.position, t), Time.deltaTime * 3);
        sphere.transform.position = Vector3.MoveTowards(electroPosition.position, Vector3.Lerp(cone.position, electroPosition.position, t), Time.deltaTime * 3);

    }

    public void ButtonOff()
    {

        //when button is off - physics is applies to the objects again and they drop

        cone.constraints = RigidbodyConstraints.None;
        torus.constraints = RigidbodyConstraints.None;
        sphere.constraints = RigidbodyConstraints.None;
    }
    

    
    




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
