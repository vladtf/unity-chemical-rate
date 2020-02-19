using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToGithub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {
        Application.OpenURL("https://github.com/vladtf/UnityChemicalSpeed");
    }
}
