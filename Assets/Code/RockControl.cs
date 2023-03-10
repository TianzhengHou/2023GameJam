using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockControl : MonoBehaviour
{
    public GameObject rock;
    public bool spowend = false;
    //private Vector2 screenBounds;
    public float respawnTime = 1.0f;
	float screenBounds = 27f;
    // Start is called before the first frame update
    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, Camera.main.transform.position.z));
        StartCoroutine(rockWave());
    }

    private void spawnRock()
    {
        GameObject gameObject = Instantiate(rock) as GameObject;
        Vector3 rootPos = GameObject.Find("Root").transform.position;
        gameObject.transform.position = new Vector3(Random.Range(-screenBounds, screenBounds), rootPos.y - 9.5f,-1);
	float scaleFactor = Random.Range(0.1f, 1f); 
	gameObject.transform.localScale = new Vector3(scaleFactor, scaleFactor, 0);
    }

    IEnumerator rockWave()
    {
        if(spowend == false)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnRock();
            spowend = true;

	    // Code to destroy rocks every 10 seconds
        //     yield return new WaitForSeconds(10);
        //    Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
