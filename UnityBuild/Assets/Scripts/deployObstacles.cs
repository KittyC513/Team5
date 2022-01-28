using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ObstacleWave());
    }

    void SpawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator ObstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacle();
        }

    }

}
