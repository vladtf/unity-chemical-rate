using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullyInvisible : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
