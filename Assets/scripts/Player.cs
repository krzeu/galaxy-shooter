using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private, public innebär att omvärlden kan kommunicera med den variablen, private gör att bara objectet med scriptet kommer åt de
    // datatyp (int = hel tal, float= decimaltal, bool= sant eller falskt, string=text)
    // varje variabel har ett namn
    // optional value
    [SerializeField]
    public float speed = 0.0f;
    void Start()
    {
        // New Position
        transform.position = new Vector3(0, 0, 0);


        
    }

   
    void Update()
    {
      CalcuateMovement();
        
    }

    void CalcuateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // new vector3 (0,0,0) * 5 / real time
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);

        // om spelaren postion är större än 0
        // y-postion = 0

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -2.55)
        {
            transform.position = new Vector3(transform.position.x, -2.55f, 0);
        }



        if (transform.position.x >= 9.3f)
        {

            transform.position = new Vector3(9.3f, transform.position.y, 0);

        }
        else if (transform.position.x <= -9.3f)
        {
            transform.position = new Vector3(-9.3f, transform.position.y, 0);
        }
    }
}
