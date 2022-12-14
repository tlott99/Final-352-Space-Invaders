using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bullet;
    public Transform explosion;
    public float collisionRadius = 0.4f;
    public bool collided = false;
    public LayerMask whatToCollideWith;

    void FixedUpdate(){
        collided = Physics2D.OverlapCircle(bullet.position, collisionRadius, whatToCollideWith);
        if (collided) Destroy(gameObject);
        if (!GetComponent<Renderer>().isVisible) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        }
        if(other.gameObject.tag == "Obstacle"){
            Destroy(gameObject);
        }
    }
}
