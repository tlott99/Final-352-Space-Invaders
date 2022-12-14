using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float bulletForce = 200.0f;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.up * bulletForce);
    }
}
