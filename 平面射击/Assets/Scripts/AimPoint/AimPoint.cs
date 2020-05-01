using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPoint : MonoBehaviour
{
    public Camera mineCamera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        transform.position = mineCamera.ScreenToWorldPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
        
    }
}
