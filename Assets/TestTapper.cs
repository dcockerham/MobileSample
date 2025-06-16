using TMPro;
using UnityEngine;

public class TestTapper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    TMP_Text textBlock;

    public Sprite[] sprites;

    int spriteIndex = 0;
    static int numTaps = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        textBlock = FindFirstObjectByType<TMP_Text>();
    }

    private void OnMouseDown()
    {
        numTaps++;
        spriteIndex++;
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
        textBlock.text = numTaps + " taps";
    }
}
