using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField]
    public float speed = 0.0f;
    [SerializeField]
    private GameObject _laserPrefab;
    [SerializeField]
    private Vector3 _laserOffset = new Vector3 (0 , 1.5f, 0);
    void Start()
    {
        // New Position
        transform.position = new Vector3(0, -2.55f, 0);


        
    }

   
    void Update()
    {
      CalcuateMovement();
        //space press, spawn gameobject, fire laser

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab,transform.position + _laserOffset, Quaternion.identity);
        }


    }
        

    void CalcuateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // new vector3 (0,0,0) * 5 / real time
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);

        // om spelaren postion är större än 0
        // y-postion = 0

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -2.55f, 0), 0);
       
        if (transform.position.x > 11f)
        {

            transform.position = new Vector3(-11f, transform.position.y, 0);

        }
        else if (transform.position.x < -11f)
        {
            transform.position = new Vector3(11f, transform.position.y, 0);
        }
    }




}


