using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
    
{

    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveSpeed = new Vector3(0, 0, -1);
        tranform.Translate(moveVector * Time.deltaTime * moveSpeed);
    }
}
