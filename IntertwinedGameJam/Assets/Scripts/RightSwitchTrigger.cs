using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSwitchTrigger : MonoBehaviour
{

    public bool playerIsInRightSwitchTrigger;
    // Start is called before the first frame update
    void Start()
    {
        playerIsInRightSwitchTrigger = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        playerIsInRightSwitchTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        playerIsInRightSwitchTrigger = false;
    }
}