using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Assignment2 : MonoBehaviour
{
    public Material Mat;
    public Slider Slider;
    public Toggle Phong;

    void Start()
    {
        Slider.onValueChanged.AddListener(value => Mat.SetFloat("_Bands_Amount", value));
        Phong.onValueChanged.AddListener(value => Mat.SetFloat("_IsPhong", value ? 1f : 0f));
    }
}
