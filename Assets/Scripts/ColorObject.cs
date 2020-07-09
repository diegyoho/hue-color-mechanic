using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour {
    
    public ColorType myColor;

    void OnEnable() {
        ColorController.OnChangeColor += ChangeColor;
    }


    void OnDisable() {
        ColorController.OnChangeColor -= ChangeColor;
    }

    void ChangeColor(ColorType currentColor) {
        GetComponent<Collider2D>().enabled = !(myColor == currentColor);
    }
}
