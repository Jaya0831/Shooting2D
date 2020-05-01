using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public int blood=100;
    public bool isalive=true;  
    public void GetHurt(int hurt)
    {
        //Debug.Log("233");
        blood -= hurt;
        if (blood <= 0)
        {
            isalive = false;
        }
    }
    private void Update()
    {
        if (isalive == false)
        {
            Destroy(gameObject);
        }
    }
}
