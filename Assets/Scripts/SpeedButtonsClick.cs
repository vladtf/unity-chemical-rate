using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private Button yourButton;

    private void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    [System.Obsolete]
    public void TaskOnClick()
    {
        var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));

        Text text = transform.Find("Text").GetComponent<Text>();
        string str = text.text;

        if (str == "-")
        {
            foreach (SphereMoveScript item in foundObj)
            {
                item.Slower();
            }
        }
        else
        {
            foreach (SphereMoveScript item in foundObj)
            {
                item.Faster();
            }
        }
    }
}