using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _FallSpeed = 4.0f;
    

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.down * _FallSpeed * Time.deltaTime);

        if (transform.position.y < -4.27f)
        {
            float randomX = Random.Range(-9.32f, 9.28f);
            transform.position = new Vector3(randomX, 8.7f, 0);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if other is player
        // dmg player
        // Destroy us
        if( other.tag == "Player")
        {
            //dmg player
            Destroy(this.gameObject);
        }

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
     
    }


}
