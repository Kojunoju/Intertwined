using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePass : MonoBehaviour
{
    public GameObject leftExitTrigger;
    public GameObject rightExitTrigger;

    public GameObject Outro;

    public FMODUnity.StudioEventEmitter Exit;


    // Start is called before the first frame update
    void Start()
    {
        Outro.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (leftExitTrigger.GetComponent<LeftPassTrigger>().playerIsInLeftPassTrigger == true && rightExitTrigger.GetComponent<RightPassTrigger>().playerIsInRightPassTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Exit.SendMessage("Play");
                Outro.SetActive(true);

            }
        }


    }
}

