using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject effectClone = Instantiate(effect, transform.position,transform.rotation);
            Destroy(effectClone, 2);
            Destroy(gameObject);
            Player.Score++;
        }
    }
}
