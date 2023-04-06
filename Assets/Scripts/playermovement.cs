using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    float speed = 10.0f;


    public Score scorefunc;
    


    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.y = Input.acceleration.y;
        dir.x = Input.acceleration.x;

       
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        
        dir *= Time.deltaTime;

        
        transform.Translate(dir * speed);


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Die();
        }
        if(collision.gameObject.tag == "Collectible")
        {

            FindObjectOfType<Score>().IncreaseScore();
            Destroy(collision.gameObject);
            
        }
    }



    public void Die()
    {

        transform.position = new Vector3(0, 0, 0);
        scorefunc.score = 0;

    }

}
