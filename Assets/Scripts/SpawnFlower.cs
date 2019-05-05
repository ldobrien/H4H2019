using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour
{
    // Flower Prefab
    public GameObject flowerPrefab;
    public GameObject BadPrefab;
    public GameObject ZFlowerPrefab;
    public GameObject SFlowerPrefab;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Spawn a flower
    void Spawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);
        int x1 = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y1 = (int)Random.Range(borderTop.position.y, borderBottom.position.y);
        int x2 = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y2 = (int)Random.Range(borderTop.position.y, borderBottom.position.y);
        int x3 = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y3 = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

        Instantiate(flowerPrefab, new Vector2(x, y), Quaternion.identity);
        Instantiate(BadPrefab, new Vector2(x1, y1), Quaternion.identity);
        Instantiate(ZFlowerPrefab, new Vector2(x2, y2), Quaternion.identity);
        Instantiate(SFlowerPrefab, new Vector2(x3, y3), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start() => InvokeRepeating("Spawn", 2, 1);
}