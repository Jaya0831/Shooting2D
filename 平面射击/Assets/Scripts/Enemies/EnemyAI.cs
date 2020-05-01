using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public float searchRadius;
    public Gun holdingGun;
    [Range(0,30)]
    private int timer = 30;
    private int timerRuler = 30;
    Vector2 view;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (Vector2.Distance(player.transform.position, transform.position) <= searchRadius)
            {
                if (Physics2D.Raycast(transform.position, player.transform.position - transform.position, searchRadius, 1 << LayerMask.NameToLayer("Wall"))){
                    return;
                }
                view = player.transform.position - transform.position;
                transform.up = view;
                if (timer == timerRuler)
                {
                    holdingGun.Shoot();
                    timer = 0;
                }
                timer++;
            }
        }
        
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0);
        Gizmos.DrawWireSphere(transform.position, searchRadius);
    }
}
