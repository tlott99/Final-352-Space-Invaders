using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform enemyObj;
    int count = 0;
    void Start(){
        StartCoroutine(enemyTimer());
    }
    void Update(){

    }
    IEnumerator enemyTimer()
    {
        yield return new WaitForSeconds(.5f);
        Instantiate(enemyObj, transform.position, transform.rotation);
        count++;
        if (count< 10) {
            StartCoroutine(enemyTimer());
        }

        
    }
}
