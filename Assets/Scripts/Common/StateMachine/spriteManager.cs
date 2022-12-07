using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;


    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }


    void Update()
    {
      
    }
}
