using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimatorController : MonoBehaviour
{
    static Animator a;
    public float speed = 1.0f;
    public float rotationSpeed = 100.0f;
    
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        movement = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        
        a.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetButtonDown("Jump"))
        {
            a.SetTrigger("isJumping");
            Debug.Log("jump");
        }
    }
}
