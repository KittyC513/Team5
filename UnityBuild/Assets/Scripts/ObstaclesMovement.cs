using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject player;
    bool gameEnd = false;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > screenBounds.y * 2)
        {
            Destroy(this.gameObject);
        }

        if(gameEnd == true)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            Destroy(this.gameObject);
            gameEnd = true;
        }
    }

 

}
