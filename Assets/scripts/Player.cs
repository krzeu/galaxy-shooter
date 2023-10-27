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
    [SerializeField]
    private float _fireRate = 0.5f;
    private float _nextFire = 0.05f;
    [SerializeField]
    private int _lives = 3;


    void Start()
    {
        // New Position
        transform.position = new Vector3(0, -2.55f, 0);


        
    }

   
    void Update()
    {
      CalcuateMovement();
       
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            _FireLaser();
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

    void _FireLaser()
    {
        Instantiate(_laserPrefab, transform.position + _laserOffset, Quaternion.identity);
        _nextFire = Time.time + _fireRate;
    }
        
        
        
    public void Damage()
    {
        _lives -= 1; 

        // om död
        //destroy

        if (_lives < 1) 
        {
            Destroy(this.gameObject);
        }
    }



}


