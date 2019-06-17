using UnityEngine;
using UnityEngine.UI;

public class Bullets_1 : MonoBehaviour
{
    
    public float speed = 1f;
   
   
    void Start()
    {

    }
    void Update()
    {
        _BulletsMovement();
    }
    //di chuyen bird
    void _BulletsMovement()
    {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
     
    }
    //va cham destroy
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Bird" )
        {          
      
            Destroy(gameObject);
        }
        else if (target.gameObject.tag == "DestroyBullets")
        {
            Destroy(gameObject);
        }
    }
}
