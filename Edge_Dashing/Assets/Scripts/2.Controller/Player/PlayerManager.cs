using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public PlayerModel model;
  public float speed;
  public float horizonSpeed;
  public float jumpForce;
  private void Awake() 
  {
    model = new PlayerModel();
    model.speed = speed;
    model.horizonSpeed = horizonSpeed;
    model.jumpForce = jumpForce;
  }
}
