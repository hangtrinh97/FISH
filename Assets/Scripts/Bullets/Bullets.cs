using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float moveForce = 2f;//toc do di chuyen
    public float jumpForce = 60f;//bay
    private bool guns;

 
   

    // public float flag = 0;//tao va cham voi tuong
    void Start()
    {

    }
    void Update()
    {
        _Bullet();


    }
    //di chuyen theo phim A or D
    void _Bullet()
    {
        float forceY = 0f;
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
        //nhan space thi ban
        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 temp = transform.position;//xac dinh vi tri hien tai
            temp.y += jumpForce * Time.deltaTime; //di chuyen ben phai
            transform.position = temp;
            
            
            
        }
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Bird"||target.gameObject.tag=="DestroyBullets"|| target.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }

}
