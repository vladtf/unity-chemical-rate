using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClick : MonoBehaviour
{
	public Button yourButton;

	[System.Obsolete]
	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	[System.Obsolete]
	public void TaskOnClick()
	{
		var foundObj = FindObjectsOfTypeAll(typeof(SphereMover));

		Text text = transform.Find("Text").GetComponent<Text>();
		string str = text.text;

		if (str == "-")
		{
			foreach (SphereMover item in foundObj)
			{
				item.Slower();
			}
		}
		else
		{
			foreach (SphereMover item in foundObj)
			{
				item.Faster();
			}
		}
	}
}