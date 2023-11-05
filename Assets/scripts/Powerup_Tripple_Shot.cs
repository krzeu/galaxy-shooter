using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup_Tripple_Shot : MonoBehaviour
{
    [SerializeField]
    public float _Fall_Speed = 3f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _Fall_Speed * Time.deltaTime);

        if (transform.position.y < -4.87)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if(player != null)
            {
                player.TripleShotAvtive();
            }
            Destroy(this.gameObject);
            
        }
        
    }

   
}
