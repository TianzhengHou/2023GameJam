using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootControl : MonoBehaviour
{
    public float distance = -0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0.0f, distance, 0.0f);
        }
    }
}
