using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorType {
    Grey,
    Red,
    Green,
    Blue
}

public class ColorController : MonoBehaviour {
    
    public ColorType currentColor;

    public static Action<ColorType> OnChangeColor;
    
    void Start() {
        ChangeCurrentColor(currentColor);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            ChangeCurrentColor(ColorType.Red);

        if(Input.GetKeyDown(KeyCode.Alpha2))
            ChangeCurrentColor(ColorType.Green);
        
        if(Input.GetKeyDown(KeyCode.Alpha3))
            ChangeCurrentColor(ColorType.Blue);
        
        if(Input.GetKeyDown(KeyCode.Alpha4))
            ChangeCurrentColor(ColorType.Grey);
    }

    public void ChangeCurrentColor(ColorType type) {
        currentColor = type;

        switch(currentColor) {
            case ColorType.Grey:
                Camera.main.backgroundColor = Color.grey;
            break;
            case ColorType.Red:
                Camera.main.backgroundColor = Color.red;
            break;
            case ColorType.Green:
                Camera.main.backgroundColor = Color.green;
            break;
            case ColorType.Blue:
                Camera.main.backgroundColor = Color.blue;
            break;
        }

        if(OnChangeColor != null)
            OnChangeColor(currentColor);
    }
}
