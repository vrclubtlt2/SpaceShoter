using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject effect;

    public float minScale = 1.0f;
    public float maxScale = 1.2f;

    public float minRotation = 1.0f;
    public float maxRotation = 1.0f;

    private void Start()
    {
        RandomScale();
        RandomRotate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject effectClone = Instantiate(effect, transform.position, transform.rotation);
            Destroy(effectClone, 2);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void RandomScale()
    {
        float scale = Random.Range(minScale, maxScale);
        transform.localScale = (Vector2)transform.localScale * scale;
    }
    private void RandomRotate()
    {
        float rotate = Random.Range(minRotation,maxRotation);
        transform.localEulerAngles = Vector3.forward * rotate;
    }
}
