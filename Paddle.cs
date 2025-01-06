using UnityEngine;

public class Paddle : MonoBehaviour
{
    private HingeJoint2D paddleHingeJoint;
    private JointMotor2D paddleMotor;

    // Motor force variables
    public float motorSpeed = 1000f; // Speed of the paddle
    public float motorTorque = 1000f; // Torque speed

    // Identify paddle side
    public bool isLeftPaddle; // True for left paddle, false for right paddle

    void Start()
    {
        paddleHingeJoint = GetComponent<HingeJoint2D>();

        // Initialize the motor
        paddleMotor = paddleHingeJoint.motor;
        paddleMotor.motorSpeed = motorSpeed;
        paddleMotor.maxMotorTorque = motorTorque;
    }

    void Update()
    {
        if (isLeftPaddle)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                paddleMotor.motorSpeed = motorSpeed;
                paddleHingeJoint.motor = paddleMotor;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                paddleMotor.motorSpeed = -motorSpeed;
                paddleHingeJoint.motor = paddleMotor;
            }
        }
        else // Right paddle
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                paddleMotor.motorSpeed = motorSpeed;
                paddleHingeJoint.motor = paddleMotor;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                paddleMotor.motorSpeed = -motorSpeed;
                paddleHingeJoint.motor = paddleMotor;
            }
        }
    }
}
