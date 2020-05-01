using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage;
    public GameObject shooter;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player"&&collision.gameObject!=shooter)
        {
            //Debug.Log(collision.gameObject.name);
            collision.gameObject.GetComponent<PlayerState>().GetHurt(bulletDamage);
            Destroy(gameObject);
            //Debug.Log(collision.gameObject.GetComponent<PlayerState>().blood);
        }
        if (collision.tag == "Enemy" && collision.gameObject != shooter)
        {
           
            collision.gameObject.GetComponent<EnemyState>().GetHurt(bulletDamage);
            Destroy(gameObject);
        }
        if (collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
