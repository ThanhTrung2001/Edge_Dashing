using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public bool canJump;
  public bool isGameOver = false;
  public float score;
  public static GameController instance{get; private set;}
  private void Awake() 
  {
    if (instance != null && instance != this) 
    { 
      Destroy(this); 
    } 
    else 
    { 
      instance = this; 
    } 
  }
  void Start()
  {
    isGameOver = false;
    score = 0;
  }

  void Update()
  {
        
  }

  public void IncrementScore()
  {
    if(isGameOver == false)
    {
      score++;
    }
  }

  public void SetGameOver()
  {
    isGameOver = true;
  }

  public void CheckCanJump()
  {
    canJump = true;
  }

  
}
