using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private Vector2 moveDir;
    public float speed=300;
    private Transform playerTransform;
    private Vector2 mousePosition;
    private Vector2 playerView;
    public Camera mainCamera;
    public Gun holdingGun;
    [Range(0,30)]
    private int timer = 30;
    private int timeRuler = 30;
    
 
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        moveDir.x = Input.GetAxis("Horizontal");
        moveDir.y = Input.GetAxis("Vertical");
        moveDir = moveDir.normalized;
        playerRigidbody.AddForce(moveDir*speed);
        if (moveDir == Vector2.zero)
        {
            playerRigidbody.velocity = Vector2.zero;
        }
        mousePosition = Input.mousePosition;
        playerView =(Vector2)mainCamera.ScreenToWorldPoint((Vector3) mousePosition)  - (Vector2)transform.position;
        
        playerTransform.up = playerView;
        if (Input.GetMouseButton(0))
        {
            timer++;
            if (timer >= timeRuler&&holdingGun.bulletCount!=0)
            {
                timer = 0;
                //Debug.Log("shoot");
                holdingGun.Shoot();
                if (holdingGun.bulletCount != -1)
                {
                    holdingGun.bulletCount--;
                }
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            holdingGun = GetComponent<Gun1>();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            holdingGun = GetComponent<Gun2>();
        }
    }
}
