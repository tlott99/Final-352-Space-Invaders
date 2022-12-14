using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sideMovement = Input.GetAxis("Horizontal")* Time.deltaTime;
        transform.Translate(moveSpeed*sideMovement,0,0);
    }
}
