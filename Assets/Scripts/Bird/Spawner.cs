using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public int scoreBird;

    [SerializeField]
    private GameObject birdHolder;

    void Start()
    {
        StartCoroutine (SpawnerBird());
        
    }
    void Update()
    {
        
    }
    //sinh ra nhieu bird
    IEnumerator SpawnerBird()
    {
        yield return new WaitForSeconds(1);
        Vector3 temp = birdHolder.transform.position;
        temp.y = Random.RandomRange(0f, 3.5f);//thay doi vi tri khi sinh ra
        Instantiate(birdHolder, temp, Quaternion.identity);
        scoreBird = scoreBird + 5;
        if (scoreBird>50)
        {
            scoreBird = 0;
        }
        StartCoroutine(SpawnerBird());

    }
    
    
}
