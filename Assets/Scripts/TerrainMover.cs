using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    [SerializeField]
    private Color color = Color.black;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
