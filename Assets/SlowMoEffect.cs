using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMoEffect : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SphereMoveScript sm = gameObject.GetComponent<SphereMoveScript>();
		sm.Slower();
	}
}
