using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSwitchTrigger : MonoBehaviour
{

    public bool playerIsInLeftSwitchTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerIsInLeftSwitchTrigger = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        playerIsInLeftSwitchTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        playerIsInLeftSwitchTrigger = false;
    }
}