using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
