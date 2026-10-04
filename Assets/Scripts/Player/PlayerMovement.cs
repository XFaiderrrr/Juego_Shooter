using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables para movimiento
    public CharacterController characterController;
    public float speed = 12f;

    //Variables para Gravedad
    private float gravity = -9.81f;
    Vector3 velocity;
    
    //Variables para comprobar el Suelo
    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;
    bool isGrounded;

    //Variables para el salto
    public float jumpHeight = 3f;


    void Update()
    {
        //Comprobar Suelo
        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);
        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        //Movimientos
        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        //Salto
        if(Input.GetKeyDown("space") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        //Gravedad
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);


    }
}
