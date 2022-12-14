using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
 
    public GameObject bullet;
    public Transform spawnPoint;

    void Update(){
        if(Input.GetButtonDown("Fire1")) Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
    }
}
