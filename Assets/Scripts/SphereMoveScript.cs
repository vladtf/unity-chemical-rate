using System;
using UnityEngine;
using UnityEngine.UI;

public class SphereMoveScript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private Slider sliderInstance;
    [SerializeField] private static int Max_Speed = 5;
    [SerializeField] private Text collisionCounter;

    private Vector3 initialiPosition;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        //for (int i = 0; i < 4; i++)
        //{
        //    Instantiate(gameObject);
        //}

        initialiPosition = transform.position;

        RandomMove();
    }

    // Update is called once per frame
    private void Update()
    {
        //Max_Speed = (int)slider.value;

        _rb.velocity = Max_Speed * (_rb.velocity.normalized);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Sphere"))
        {
            Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);

            IncrementCollision();
        }
        else
        {
            //Debug.Log("Wall");

            Vector3 velocity = _rb.velocity;
            _rb.velocity = new Vector3(-velocity.x, UnityEngine.Random.Range(-1, 1), -velocity.z);

            //_rb.AddForce(new Vector3(0, 0, 0));
            //gameObject.transform.Translate(AddNoiseOnAngle(5, 5));
        }
    }

    private void IncrementCollision()
    {
        float current = Int32.Parse(collisionCounter.text) + 1;
        collisionCounter.text = current.ToString();
    }

    private Vector3 RandomVector(float min, float max)
    {
        var x = UnityEngine.Random.Range(min, max);
        var y = UnityEngine.Random.Range(min, max);
        var z = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y, z);
    }

    private void RandomMove()
    {
        _rb.velocity = RandomVector(0f, 5f);
    }

    private Vector3 AddNoiseOnAngle(float min, float max)
    {
        float xNoise = UnityEngine.Random.Range(min, max);
        float yNoise = UnityEngine.Random.Range(min, max);
        float zNoise = 0;

        // Now get the angle between w.r.t. a vector 3 direction
        Vector3 noise = new Vector3(
            Mathf.Sin(2f * 3.1415926f * xNoise / 360),
            Mathf.Sin(2f * 3.1415926f * yNoise / 360),
            0);
        return noise;
    }

    [System.Obsolete]
    public void CurrentSpeed(float value)
    {
        if (Max_Speed == 0)
        {
            var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));
            foreach (SphereMoveScript item in foundObj)
            {
                item.Faster();
            }
        }
        Max_Speed = (int)value;
    }

    public void Slower()
    {
        if (Max_Speed - 5 > 0)
        {
            Max_Speed -= 5;
        }
        else
        {
            Max_Speed = 0;
        }
    }

    public void Faster()
    {
        Max_Speed += 5;

        if (_rb.velocity.normalized == _rb.velocity.normalized * 0)
            RandomMove();
    }

    public void SpawnNew()
    {
        Instantiate(gameObject);
    }

    public void Remove()
    {
        Destroy(gameObject);
    }

    public void RestartBalls()
    {
        transform.position = initialiPosition;
    }

    [System.Obsolete]
    public void RemoveAllBalls()
    {
        var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));
        for (int i = 0; i < foundObj.Length - 2; i++)
        {
            (foundObj[i] as SphereMoveScript).Remove();
        }
    }
}