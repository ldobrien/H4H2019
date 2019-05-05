using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour {
    int foodCount = 0;
    int max = 1;
    int flowerPoint = 0;
    int foodPoint = 0;

    public HealthBar health;
    public Interactive inter;

    void OnTriggerEnter2D(Collider2D coll) {
        Debug.Log(coll.name);
        if(coll.name.StartsWith("BadPrefab(Clone)")) {
            // Reduce points
            flowerPoint = 0;

            Destroy(coll.gameObject);
        }
        else if(coll.name.StartsWith("FlowerPrefab(Clone)")) {
            // Add points
            flowerPoint++;
            health.IncreaseHealth();
            inter.eaten = true;
            // Debug.Log("Current Health");
           // health.CurrentHealth += 10;

            Destroy(coll.gameObject);
        }
    }
}
