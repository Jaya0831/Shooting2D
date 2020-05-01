using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : Gun
{
    public guns gun1;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletCount = -1;
        bulletSpeed = 10;
        damage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
