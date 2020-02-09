using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMover : MonoBehaviour
{
    public Color altColor = Color.black;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }
    [SerializeField]
    private float speed = 2;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.R))
        {
            //alter color   
            altColor.r += 0.1f;

            rend.material.color = altColor;

            print("r presssed");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //alter color   
            altColor.r -= 0.1f;

            rend.material.color = altColor;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //SceneManager.LoadScene(0);
    }
}
