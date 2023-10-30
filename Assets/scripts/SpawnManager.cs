using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _Enemyprefab;
    [SerializeField]
    private float _Spawnrate = 5.0f; 

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    
    void Update()
    {

        //StartCoroutine(SpawnRoutine());

    }

    // spawn game objects
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-9.32f, 9.28f), 8.3f, 0 );
            Instantiate(_Enemyprefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_Spawnrate);


        }
        
       
       
        // spawn game objects every 5 sec
        //create a coroutine of type IEnumerator 
        //while loop
    }
        
        

        










}
    

        
        
        
        
        
        
        


    




