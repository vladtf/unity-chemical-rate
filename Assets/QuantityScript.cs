using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuantityScript : MonoBehaviour
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
		var foundObj = FindObjectsOfTypeAll(typeof(SphereMoveScript));

		Text text = transform.Find("Text").GetComponent<Text>();
		string str = text.text;

		if (str == "-")
		{
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
			foreach (SphereMoveScript item in foundObj)
			{
				item.SpawnNew();
			}
		}
	}
}
