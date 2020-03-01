using UnityEngine;
using UnityEngine.UI;

public class SlowMoEffect : MonoBehaviour
{
    [SerializeField] private Button yourButton;

    private void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        SphereMoveScript sm = gameObject.GetComponent<SphereMoveScript>();
        sm.Slower();
    }
}