using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody _rb;
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material.color = color;
        
        _rb = GetComponent<Rigidbody>();
        //_rb.velocity = new Vector3(0, 40);
        _rb.maxAngularVelocity = maxAngularVelocity;
        StartCoroutine(ChangeRotation());
    }

    [SerializeField]
    private Color color = Color.green;
    public int maxAngularVelocity = 1000;
    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator ChangeRotation()
    {
        while (true)
        {
            _rb.AddTorque(new Vector3(10 * UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f)), ForceMode.Impulse);
            yield return new WaitForSeconds(1);
        }
    }
}
