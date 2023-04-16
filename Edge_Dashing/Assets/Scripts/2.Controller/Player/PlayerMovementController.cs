using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
  private PlayerManager manager;
  Rigidbody rb;
  private void Start() 
  {
    rb = GetComponent<Rigidbody>();
    manager = GetComponent<PlayerManager>();
  }
  private void FixedUpdate() 
  {
    Moving();
  }

  void Moving()
  {
    rb.AddForce(0,0,manager.model.speed*Time.deltaTime);
    MovingLeft();
    MovingRight();
    Jumping();
  }

  void MovingLeft()
  {
    if(Input.GetAxis("Horizontal") > 0 )
    {
      rb.AddForce(manager.model.horizonSpeed*Time.deltaTime,0,0);
    }
  }
  void MovingRight()
  {
    if(Input.GetAxis("Horizontal") < 0 )
    {
      rb.AddForce(-manager.model.horizonSpeed*Time.deltaTime,0,0);
    }
  }

  void Jumping()
  {
    if(true) // GameController.GameModel.canJump = true 
    {
      if(Input.GetAxis("Vertical") > 0  || Input.GetKey("space")) // 
      { 
        rb.AddForce(0,manager.model.jumpForce*Time.deltaTime,0);
      }
    }
  }
}
