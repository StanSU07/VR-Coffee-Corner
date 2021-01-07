using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgChange : MonoBehaviour
{
    public Image image;
    public GameObject YogaPoses;
    public List<Sprite> ListOfImages;
    private int img;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        YogaPoses.SetActive(false);
        img = 0;
        image.sprite = ListOfImages[img];

    }

    public void ShowOrHidePoses()
    {
        if (!YogaPoses.activeSelf)
        {
            YogaPoses.SetActive(true);
        }
        else
        {
            YogaPoses.SetActive(false);
        }
    }

    //changes the sprite image to the next one on the list
    public void ChangeImage()
    {
        if (img < ListOfImages.Count)
        {
            img++;
        }

        if (img == ListOfImages.Count)
        {
            img = 0;
        }

        image.sprite = ListOfImages[img];
    }
}
