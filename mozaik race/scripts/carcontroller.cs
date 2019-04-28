using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class carcontroller : MonoBehaviour

{

    public float speed = 1500f;
    public float rotationSpeed = 0f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public Rigidbody2D rb;
    //public bool isflat = true;




    private Vector2 rotation;
    private float movement = 0f;
    //private float rotation = 0f;
    private bool RightisPressed;
    private bool LeftisPressed;

    void Update()
    {
        rb = GetComponent< Rigidbody2D>();

        if (RightisPressed)
            movement = -1 * speed;

        else if (LeftisPressed)
            movement = 1 * speed;

        else
            movement = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }
          
        




    }

    void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }
        // rotation = Vector2.zero;
        //rotation.y = Input.acceleration.y * Time.deltaTime * rotationSpeed;
        //rotation(Input.acceleration * rotationSpeed * Time.fixedDeltaTime);

        //Vector2 forgo = Input.acceleration;
        //if(isflat)
        //{
        //  forgo = Quaternion.Euler(90,90,90) * forgo;

        //}

        //rb.AddForce(forgo);
        //float temp = Input.acceleration.x;
        //Debug.Log(temp);
        //transform.Rotate(45, 45, -temp * rotationSpeed);

    }   

    public void RightPressed()
    {
            RightisPressed = true;



    }


    public void NotRightPressed()
    {
        RightisPressed = false;


    }
    public void LeftPressed()
    {
        LeftisPressed = true;



    }


    public void NotLeftPressed()
    {
        LeftisPressed = false;


    }

    
}