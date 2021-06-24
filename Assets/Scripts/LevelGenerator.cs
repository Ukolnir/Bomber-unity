using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Texture2D map;
    public ColorToPrefab[] colorMappings;
    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();    
    }

    void GenerateLevel() {
        for (int x = 0; x < map.width; ++x)
            for (int y = 0; y < map.height; ++y)
                GenerateTile(x, y);
    }

    void GenerateTile(int x, int y) {
        Color pColor = map.GetPixel(x, y);

        if (pColor.a == 0) {
            return; //transparrent
        }
        
        foreach (ColorToPrefab colorMapping in colorMappings) {
            if (colorMapping.color.Equals(pColor)) {
                Vector2 position = new Vector2(x, y);
                Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
            }
        }
    }
}
