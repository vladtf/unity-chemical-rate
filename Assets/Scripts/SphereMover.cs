using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 40);
    }
    [SerializeField]
    private Color color = Color.green;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
