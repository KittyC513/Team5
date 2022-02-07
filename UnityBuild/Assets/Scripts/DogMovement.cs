 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FacingDirection { Right,Left}

public class DogMovement : MonoBehaviour
{


    public FacingDirection direction;
    public float directionX;
    Rigidbody2D rb;
    float curPosition;
    float oriPosition;

    SpriteRenderer sp;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        oriPosition = this.transform.position.x;
        
        


    }

    // Update is called once per frame
    void Update()
    {
        curPosition = this.transform.position.x;
        directionX = curPosition - oriPosition;
        oriPosition = curPosition;

        if (directionX < 0)
        {
            direction = FacingDirection.Right;
            
        }
        else if(directionX >0)
        {
            direction = FacingDirection.Left;
            
        }
        SetSpriteDirection();
        
    
    }


    public void SetSpriteDirection()
    {
        switch (direction)
        {
            case FacingDirection.Left:
                {
                    sp.flipX = true;
                    break;
                }
            case FacingDirection.Right:
                {
                    sp.flipX = false;
                    break;
                }
                    
 
        }
    }
}
