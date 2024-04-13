using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2;
    public GameObject effect;
    private void Start()
    {
        Destroy(gameObject, 10);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GameObject effectClone = Instantiate(effect, transform.position, transform.rotation);
            Destroy(effectClone, 2);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
