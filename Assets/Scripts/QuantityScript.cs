using UnityEngine;
using UnityEngine.UI;

public class QuantityScript : MonoBehaviour
{
    [SerializeField] private Button yourButton;

    [System.Obsolete]
    private void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    [System.Obsolete]
    public void TaskOnClick()
    {
        Text text = transform.Find("Text").GetComponent<Text>();
        string str = text.text;

        if (str == "-")
        {
            var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));
            if (foundObj.Length > 2)
            {
                for (int i = 0; i < foundObj.Length / 2; i++)
                {
                    (foundObj[i] as SphereMoveScript).Remove();
                }
            }
        }
        else
        {
            var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));
            foreach (SphereMoveScript item in foundObj)
            {
                item.SpawnNew();
            }
        }
    }
}