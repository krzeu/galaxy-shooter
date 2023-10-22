using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        
        if (transform.position.y > 8.3f)
        {
            Destroy(gameObject);
        }
    }
}
