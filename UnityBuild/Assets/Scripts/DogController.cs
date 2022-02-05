using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogController : MonoBehaviour
{
    bool gameEnd = false;
    [SerializeField] private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        Vector3 dogPosition = transform.position = mouseWorldPosition;

        //Vector3 dogPosition = transform.position = new Vector3(mouseWorldPosition.x - 2f, mouseWorldPosition.y -2f, mouseWorldPosition.z);


        // Debug.DrawLine(dogPosition, mouseWorldPosition, Color.black);
        if(gameEnd == true)
        {
            SceneManager.LoadScene(2);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstcle")
        {
            Destroy(other.gameObject);
            Debug.Log("Hello");
            gameEnd = true;
        }
    }


}
