using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layer : MonoBehaviour
{
    public float moveForce = 1f;//toc do di chuyen
   
    [SerializeField]
    private GameObject bulletsHolder;
   
    void Start()
    {
        
    }
    void Update()
    {
        _Guns();
        _SpawnerBullets();
        
       

    }
    
    //di chuyen theo phim A or D
    void _Guns()
    {
        //float x = 0;
        float h = Input.GetAxisRaw("Horizontal");//cho phep phimA or D
        if (h > 0)
        {
            Vector3 temp = transform.position;//xac dinh vi tri hien tai
            temp.x += moveForce * Time.deltaTime; //di chuyen ben phai
            transform.position = temp;
        }
        else if (h < 0)
        {
            Vector3 temp = transform.position;
            temp.x -= moveForce * Time.deltaTime;
            transform.position = temp;
        }
    }
    //space ban
    void _SpawnerBullets()
    {
        if (Input.GetKey(KeyCode.Space))
        {
         
            Instantiate(bulletsHolder, transform.position, Quaternion.identity);
        }
    }
 

}

