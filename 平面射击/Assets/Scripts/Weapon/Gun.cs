using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int bulletCount; 
    public int damage;
    public GameObject bulletPrefab;
    public GameObject player;
    public float bulletSpeed ;
    public enum guns
    {
        gun1,
        gun2
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpeed * transform.up, ForceMode2D.Impulse);
        bullet.GetComponent<Bullet>().bulletDamage = damage;
        bullet.GetComponent<Bullet>().shooter = gameObject;
    }
}
