using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SpriteAtlas : MonoBehaviour
{
    public static int score;
    public static Dictionary<string, Sprite> dictSprites = new Dictionary<string, Sprite>();
    public Sprite[] sprites;

    void Start()
    {
        score = 0;
        sprites = Resources.LoadAll<Sprite>("sprites");

        foreach (Sprite sprite in sprites)
        {
            dictSprites.Add(sprite.name, sprite);
        }
    }
}
