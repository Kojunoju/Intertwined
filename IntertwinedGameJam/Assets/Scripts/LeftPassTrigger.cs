using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPassTrigger : MonoBehaviour
{
  public bool playerIsInLeftPassTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerIsInLeftPassTrigger = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        playerIsInLeftPassTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        playerIsInLeftPassTrigger = false;
    }
}