using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        RandomMove();
    }

    [SerializeField]
    private int Max_Speed = 30;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RandomMove();
        }
    }

    private void RandomMove()
    {
        int x = Random.Range(-Max_Speed, Max_Speed);
        int y = Random.Range(-Max_Speed, Max_Speed);
        int z = Random.Range(-Max_Speed, Max_Speed);

        _rb.velocity = new Vector3(x, y, z);
    }
    
}
