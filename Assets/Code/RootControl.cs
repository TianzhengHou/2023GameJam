using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootControl : MonoBehaviour
{
    public float distance = -2f; //larger - number speeds up root movement
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
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > -27)
        {
            transform.position = transform.position + new Vector3(distance * Time.deltaTime, 0.0f, 0.0f);
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x < 28)
        {
            transform.position = transform.position + new Vector3(-(distance * Time.deltaTime), 0.0f, 0.0f);
        }
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && transform.position.y < -1)
        {
            transform.position = transform.position + new Vector3(0.0f, -2 * (distance * Time.deltaTime), 0.0f);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        root.position = orgion.position;
	    tr.Clear();


	
        Instantiate(root, orgion.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

}
