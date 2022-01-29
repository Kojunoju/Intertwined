using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Intro;

void Start() 
{
    Intro.SetActive(true);
}
    // Start is called before the first frame update
void Update()
    {
        ClearTitle();
    }

    void ClearTitle()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Intro.SetActive(false);
        }
    }
}
