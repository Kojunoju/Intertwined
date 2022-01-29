using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSwitch : MonoBehaviour
{
    public GameObject leftSwitchTrigger;


    public FMODUnity.StudioEventEmitter SwitchPress;

    public GameObject GateBL;

    public GameObject GateTL;

    public GameObject GateBR;

    public GameObject GateTR;

    public GameObject BOL;

    public GameObject BOR;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (leftSwitchTrigger.GetComponent<LeftSwitchTrigger>().playerIsInLeftSwitchTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SwitchPress.SendMessage("Play");
                GateBL.SetActive (!GateBL.activeInHierarchy);
                GateTL.SetActive (!GateTL.activeInHierarchy);
                GateBR.SetActive (!GateBR.activeInHierarchy);
                GateTR.SetActive (!GateTR.activeInHierarchy);
                BOR.SetActive (!BOR.activeInHierarchy);
                BOL.SetActive (!BOL.activeInHierarchy);
                
            }
        }


    }
}