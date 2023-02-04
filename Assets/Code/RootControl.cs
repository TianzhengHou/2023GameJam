using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootControl : MonoBehaviour
{
    public float distance = -0.1f;
    public Transform root;
    public Transform orgion;

    public GameObject Root;
    public TrailRenderer tr;

    // Start is called before the first frame update
    void Start()
    {
	    tr = GetComponent<TrailRenderer>();
	
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        root.position = orgion.position;
	tr.Clear();
	
        //Instantiate(root, orgion.position, Quaternion.identity);
        //Destroy(this.gameObject);
    }

}
