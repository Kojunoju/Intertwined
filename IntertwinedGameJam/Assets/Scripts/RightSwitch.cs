using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSwitch : MonoBehaviour
{
    public GameObject rightSwitchTrigger;


    public FMODUnity.StudioEventEmitter SwitchPressR;

    public bool SwitchPressed = false;

    public GameObject GateBL;

    public GameObject GateTL;

    public GameObject GateBR;

    public GameObject GateTR;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rightSwitchTrigger.GetComponent<RightSwitchTrigger>().playerIsInRightSwitchTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SwitchPressR.SendMessage("Play");
                GateBL.SetActive (!GateBL.activeInHierarchy);
                GateTL.SetActive (!GateTL.activeInHierarchy);
                GateBR.SetActive (!GateBR.activeInHierarchy);
                GateTR.SetActive (!GateTR.activeInHierarchy);
                
            }
        }


    }
}
