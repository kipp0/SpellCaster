using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    static Animator a;
    public float speed = 1.0f;
    public float rotationSpeed = 100.0f;
    
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        float translation = movement.y * speed;
        float rotation = movement.x * rotationSpeed;


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        // Vector3 player_movement = new Vector3(horizontal_input,0f,vertical_input)*speed*Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);
        
        a.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetButtonDown("Jump"))
        {
            a.SetTrigger("isJumping");
            Debug.Log("jump");
        }

        if (translation > 0.01 && translation < 3)
        {
            
        }
    }
}
