using UnityEngine;

public class FullyInvisible : MonoBehaviour
{
    [System.Obsolete]
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}