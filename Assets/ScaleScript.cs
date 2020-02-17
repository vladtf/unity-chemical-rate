using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ScaleBigger()
    {
        transform.localScale += transform.localScale / 5;
    }
    public void ScaleSmaller()
    {
        transform.localScale -= transform.localScale / 5;
    }
}
