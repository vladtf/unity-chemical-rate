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

        int x = Random.Range(-30, 30);
        int y = Random.Range(-30, 30);
        int z = Random.Range(-30, 30);
        _rb.velocity = new Vector3(x, y, z);

        //_rb.maxAngularVelocity = maxAngularVelocity;

        //StartCoroutine(ChangeRotation());
    }

    [SerializeField]
    private Color color = Color.green;
    public int maxAngularVelocity = 1000;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
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
