using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    #region Variables

    [SerializeField] float speed, jumppower;
    [SerializeField] bool IsGrounded;
    private Rigidbody2D RB;


    #endregion Variables


    
    void Start () 
    {
		RB = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        
        RB.velocity = new Vector2( speed , RB.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            RB.velocity = Vector2.up * jumppower;
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "floor")
        {
            IsGrounded = true;
        }

        if(other.transform.tag == "die")
        {
            playerDie();
        }

    }

     void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if(collisionInfo.transform.tag == "floor")
        {
            IsGrounded = false;
        }
    }

    void playerDie()
    {
        
    }
    


}
