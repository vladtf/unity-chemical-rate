using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMoEffect : MonoBehaviour
{
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (Time.timeScale != 0.3f)
        {
            Time.timeScale = 0.3f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }

    }

}
