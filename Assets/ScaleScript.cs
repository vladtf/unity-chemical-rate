﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ScaleScript : MonoBehaviour
{
    //Vector3 minScale;
    //public Vector3 maxScale;
    public float speed = 2f;
    public float duration = 10f;
    public Button buttonBigger;
    public Button buttonSmaller;
    public Transform cover;
    void Start()
    {
        //while (true)
        //{
        //    yield return ScaleTo(transform.localScale, transform.localScale += transform.localScale / 5, duration);
        //    yield return ScaleTo(transform.localScale, transform.localScale -= transform.localScale / 5, duration);
        //}


    }

    public void Bigger()
    {
        StartCoroutine(ScaleBigger());

        //Vector3 temp = new Vector3(0, 5f, 0);
        //cover.transform.position += temp;
    }
    public void Smaller()
    {
        StartCoroutine(ScaleSmaller());

        //Vector3 temp = new Vector3(0, 5f, 0);
        //cover.transform.position -= temp;
    }

    public IEnumerator ScaleBigger()
    {
        yield return ScaleTo(transform.localScale, transform.localScale += transform.localScale / 5, duration);
    }
    public IEnumerator ScaleSmaller()
    {
        yield return ScaleTo(transform.localScale, transform.localScale -= transform.localScale / 5, duration);
    }

    public IEnumerator ScaleTo(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);

            cover.transform.position = new Vector3(cover.transform.position.x, gameObject.GetComponent<Collider>().bounds.max.y, cover.transform.position.z);

            yield return null;
        }
    }

}
