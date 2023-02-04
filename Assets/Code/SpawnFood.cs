using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    public Camera mainCamera;
    //public Transform borderTop;
    //public Transform borderBottom;
    //public Transform borderLeft;
    //public Transform borderRight;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }

    // Spawn one piece of food
    void Spawn()
    {
        float cameraHeight = mainCamera.orthographicSize * 2;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        // x position between left & right border
        int x = (int)Random.Range(mainCamera.transform.position.x - cameraWidth / 4,
                                  mainCamera.transform.position.x + cameraWidth / 4);

        // y position between top & bottom border
        int y = (int)Random.Range(mainCamera.transform.position.y - cameraHeight / 4,
                                  mainCamera.transform.position.y - cameraHeight / 2);

        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector3(x, y),
                    Quaternion.identity); // default rotation
    }
}
