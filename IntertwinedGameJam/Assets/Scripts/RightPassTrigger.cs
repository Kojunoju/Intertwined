using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPassTrigger : MonoBehaviour
{
  public bool playerIsInRightPassTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerIsInRightPassTrigger = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        playerIsInRightPassTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        playerIsInRightPassTrigger = false;
    }
}