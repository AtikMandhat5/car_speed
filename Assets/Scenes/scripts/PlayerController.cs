using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float carSpeed=5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        print(Time.deltaTime);  
    }

    // Update is called once per frame
    void Update()
    {
        // player innput 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // transform.Translate(0,0,1);
        //we move the vehicle forward
        transform.Translate(Vector3.forward  * Time.deltaTime * carSpeed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime *turnSpeed* horizontalInput);
        // we turn the vehicle
        transform.Rotate(Vector3.up  * Time.deltaTime *turnSpeed* horizontalInput);
        
    }
}
