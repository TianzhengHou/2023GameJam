using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootControl : MonoBehaviour
{
    public float distance = -2f; //larger - number speeds up root movement
    public Transform root;
    public Transform orgion;

    public GameObject Root;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0.0f, distance * Time.deltaTime, 0.0f);
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(distance * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(-(distance * Time.deltaTime), 0.0f, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        root.position = orgion.position;
        //Instantiate(root, orgion.position, Quaternion.identity);
        //Destroy(this.gameObject);
    }

}
