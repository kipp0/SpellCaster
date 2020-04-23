using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float rotation_speed =1;
    public Transform Target,Player;
    float mouseX,mouseY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }
    
    void Update(){
        CamControl();
    }
    void CamControl(){
        mouseX += Input.GetAxis("Mouse X")*rotation_speed;
        mouseY +=Input.GetAxis("Mouse Y")*rotation_speed;
        mouseY +=Mathf.Clamp(mouseY,-35,60);

        transform.LookAt(Target);

        if (Input.GetMouseButton(0))
        {
            Cursor.visible = false;

            Target.rotation = Quaternion.Euler(mouseY,mouseX,0);
        }else if (Input.GetMouseButton(1))
        {
            Cursor.visible = false;

            Target.rotation = Quaternion.Euler(mouseY,mouseX,0);
            Player.rotation = Quaternion.Euler(0,mouseX,0);
        } else {
            Cursor.visible = true;
        }
        
    }
}
