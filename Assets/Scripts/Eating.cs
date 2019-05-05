using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour 
{

    public HealthBar health;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name.StartsWith("BadPrefab(Clone)"))
        {
            health.KillHealth();
            Destroy(coll.gameObject);
        }
        else if(coll.name.StartsWith("FlowerPrefab(Clone)"))
        {
            // Add points
            health.IncreaseHealth();
            Destroy(coll.gameObject);
        }
    }
}
