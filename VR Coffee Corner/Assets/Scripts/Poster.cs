using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
public SpriteRenderer spriteRenderer;
public Sprite[] spriteArray;
public int currentSprite;


public void ChangeSprite()
{
    spriteRenderer.sprite = spriteArray[currentSprite];
    currentSprite++;

    if(currentSprite >= spriteArray.Length)
    {
        currentSprite = 0;
    }
}
}
