using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    private int blood=30;
    private bool isalive=true;
    public GameObject player;
    public void GetHurt(int damage)
    {
        blood -= damage;
        if (blood <= 0)
        {
            isalive = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isalive == false)
        {
            Destroy(gameObject);
            player.GetComponent<Gun2>().bulletCount += 5;

        }
        
    }
    
    
}
