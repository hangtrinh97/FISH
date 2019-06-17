using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public float speed=5f;
    public Score diem;
    public Spawner diem1;
    int i = 0;

    void Start()
    {
        diem = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();//dong bo bien cua 2 class
        diem1 = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }
    void Update()
    {
        _BirdMovement();

    }

    //di chuyen bird
    void _BirdMovement()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
    //va cham
    void OnCollisionEnter2D(Collision2D target)
    {
       if (target.gameObject.tag=="Destroy") 
        {
           
            Destroy(gameObject);
         
        }
        if (target.gameObject.tag == "Bullets")
        {
            i = diem1.scoreBird;
            Destroy(gameObject);
            diem.score=diem.score+ i;
        }
    }
    

}
