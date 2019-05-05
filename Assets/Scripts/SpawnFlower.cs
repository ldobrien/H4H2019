using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour {
    // Flower Prefab
    public GameObject flowerPrefab;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Spawn a flower
    void Spawn() {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

        Instantiate(flowerPrefab, new Vector2(x, y), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start() => InvokeRepeating("Spawn", 2, 1);
}
