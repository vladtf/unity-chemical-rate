using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody _rb; 
    public GameObject explosionPrefab;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        //for (int i = 0; i < 4; i++)
        //{
        //    Instantiate(gameObject);
        //}


        RandomMove();
    }

    [SerializeField]
    private int Max_Speed = 30;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            Slower();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Faster();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);

        // other code which destroys the player
    }
    private void RandomMove()
    {
        int x = Random.Range(-Max_Speed, Max_Speed);
        int y = Random.Range(-Max_Speed, Max_Speed);
        int z = Random.Range(-Max_Speed, Max_Speed);

        _rb.velocity = new Vector3(x, y, z);
    }

    public void Slower()
    {
        _rb.velocity = _rb.velocity - _rb.velocity / 5;
    }
    public void Faster()
    {
        _rb.velocity = _rb.velocity + _rb.velocity / 5;
    }

    public void SpawnNew()
    {
        Instantiate(gameObject);
    }

    public void Remove()
    {
        Destroy(gameObject);
    }

}
