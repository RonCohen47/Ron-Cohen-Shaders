using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    [SerializeField] private Material _healthBarMat;
    public float healthValue;
    private void Update()
    {
        _healthBarMat.SetFloat("_HealthValue", healthValue);
    }
}
