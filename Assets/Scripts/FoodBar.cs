﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    public Slider foodbar;
    public float Current { get; set; }
    public float Max { get; set; }
    public float increment;
    // Start is called before the first frame update
    void Start()
    {
        Max = 1000f;
        increment = 10f;
        Current = 0;
        foodbar.value = CalculateFood();
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            UpdateFoodBar();
        }
    }

    float CalculateFood()
    {
        return Current / Max;
    }

    void UpdateFoodBar()
    {
        Current += increment;
        foodbar.value = CalculateFood();
    }
}
