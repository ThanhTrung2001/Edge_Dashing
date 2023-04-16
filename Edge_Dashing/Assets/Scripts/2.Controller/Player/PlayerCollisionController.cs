using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
  private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Object"))
    {
      Debug.Log("Hit!");
    }
  }
}
