using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootControl : MonoBehaviour
{
    GameObject root;
    // Start is called before the first frame update
    void Start()
    {
        root = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
        root.gameObject.transform.localScale += newVector3(0, -50, 0);



    }
}
