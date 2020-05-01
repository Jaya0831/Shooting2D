using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCamera : MonoBehaviour
{
    public GameObject player;
    public Collider2D mapCollider;
    Vector3 minMap, maxMap;
    float C_width, C_height;
    // Start is called before the first frame update
    void Start()
    {
        maxMap = mapCollider.bounds.max;
        minMap = mapCollider.bounds.min;
        C_height = GetComponent<Camera>().orthographicSize;
        C_width = C_height * ((float)Screen.width / (float)Screen.height);

    }
    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            x = Mathf.Clamp(x, minMap.x + C_width, maxMap.x - C_width);
            y = Mathf.Clamp(y, minMap.y + C_height, maxMap.y - C_height);
            transform.position = new Vector3(x, y, transform.position.z);
        }
        
    }
}
