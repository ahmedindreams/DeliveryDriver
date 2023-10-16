using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float turnSpeed = 300f;
    [SerializeField]float MoveSpeed = 10f;
     [SerializeField] public VariableJoystick variableJoystick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float turnAmount = variableJoystick.Horizontal;
        float moveAmount = variableJoystick.Vertical;
        // float turnAmount = Input.GetAxis("Horizontal");
        // float moveAmount = Input.GetAxis("Vertical");
        // transform.Rotate(0, 0, -turnAmount*turnSpeed* Time.deltaTime);
        transform.Rotate(0, 0, turnAmount*-turnSpeed* Time.deltaTime);
        transform.Translate(0, moveAmount*MoveSpeed*Time.deltaTime, 0);

       

       
    }
}
