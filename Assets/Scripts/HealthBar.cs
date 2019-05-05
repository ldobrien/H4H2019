using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public float decrement;

    public Slider healthbar;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 1000f;
        decrement = -1f;
        CurrentHealth = MaxHealth;
        healthbar.value = CurrentHealth / MaxHealth;
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }

    public void IncreaseHealth()
    {
        CurrentHealth += 100;
        healthbar.value = CurrentHealth / MaxHealth;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //if(CurrentHealth + decrement <= 0) { 
        //    //you ded
        //}
        //else
        //{
        // Debug.Log(MaxHealth);
            CurrentHealth += decrement;
            healthbar.value = CurrentHealth / MaxHealth;
        //}
    }
}