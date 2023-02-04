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
        transform.position = transform.position + new Vector3(0.0f, distance * Time.deltaTime, 0.0f);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(distance * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(-(distance * Time.deltaTime), 0.0f, 0.0f);
        }
    }

}
