using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : Gun
{
    public guns gun2;

    // Start is called before the first frame update
    void Start()
    {
        bulletCount = 10;
        bulletSpeed = 5;
        damage = 30;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
