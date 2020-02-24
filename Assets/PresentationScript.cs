using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentationScript : MonoBehaviour
{
    [SerializeField] private GameObject slide;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private List<Texture2D> pictures;

    private int imageIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            imageIndex = 0;
            slide.GetComponent<RawImage>().texture = pictures[imageIndex];

            mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && imageIndex > 0)
        {
            imageIndex--;
            slide.GetComponent<RawImage>().texture = pictures[imageIndex];
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && imageIndex < pictures.Count)
        {
            imageIndex++;
            slide.GetComponent<RawImage>().texture = pictures[imageIndex];
        }

    }
}
