using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticsCount : MonoBehaviour
{
    [SerializeField] private Text collisionCounter;
    [SerializeField] private float waitTime = 1.0f;

    private float timer = 0.0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            collisionCounter.text = "0";

            timer -= waitTime;
        }
    }
}