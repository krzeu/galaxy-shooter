using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup_Tripple_Shot : MonoBehaviour
{
    [SerializeField]
    private GameObject _TripleShot;
    [SerializeField]
    private GameObject _QuadShot;
    private bool _Triple_Active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "Player")
        {

            TripplePower();

        }
    }
               
     private void TripplePower()
    {
        Instantiate(_QuadShot, transform.position, Quaternion.identity);
        
        Destroy(this.gameObject);

    }

}
