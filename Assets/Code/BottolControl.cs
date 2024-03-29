using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleControl : MonoBehaviour
{
    public GameObject bottle;
    public bool spowend = false;
    private Vector2 screenBounds;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, Camera.main.transform.position.z));
        StartCoroutine(bottleWave());
    }

    private void spawnBottle()
    {
        GameObject gameObject = Instantiate(bottle) as GameObject;
        Vector3 rootPos = GameObject.Find("Root").transform.position;
        gameObject.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), rootPos.y - 9.5f,-1);
	float scaleFactor = Random.Range(0.1f, 1f); 
	gameObject.transform.localScale = new Vector3(scaleFactor, scaleFactor, 0);
    }

    IEnumerator bottleWave()
    {
        if(spowend == false)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBottle();
            spowend = true;

            yield return new WaitForSeconds(10);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}