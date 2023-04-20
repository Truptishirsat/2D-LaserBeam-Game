using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] GameObject powerPrefab;
    [SerializeField] float minBound;
    [SerializeField] float maxBound;
    [SerializeField] float secondSpawn;
    
    void Update()
    {

    }  


    void Start()
    {
        StartCoroutine(SpawnPower());
    }

    IEnumerator SpawnPower()
    {
        while(true)
        {
            var x = Random.Range(minBound, maxBound);
            var position = new Vector2(x, transform.position.y);
            GameObject gameObject = Instantiate(powerPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
        
    }
    
}
