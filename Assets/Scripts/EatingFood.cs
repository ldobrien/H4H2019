using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingFood : MonoBehaviour
{

    public FoodBar food;
    public GameObject strawberry;
    public GameObject zucchini;

    bool SFPIsTure = false;
    bool ZFPIsTure = false;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name.StartsWith("SFlowerPrefab(Clone)") && SFPIsTure == true)
        {
            // Add points
            food.UpdateFoodBar();
            int x = (int)(coll.gameObject.transform.position.x);
            int y = (int)(coll.gameObject.transform.position.y);


            var straw = Instantiate(strawberry, new Vector2(x, y), Quaternion.identity);
            
            Destroy(coll.gameObject);
            straw.GetComponent<strawberry>().gravestone = true;
            SFPIsTure = false;
        }
        else if (coll.name.StartsWith("SFlowerPrefab(Clone)"))
        {
            SFPIsTure = true;
            Destroy(coll.gameObject);
        }
        if (coll.name.StartsWith("ZFlowerPrefab(Clone)") && ZFPIsTure == true)
        {
            // Add points
            food.UpdateFoodBar();
            int x = (int)(coll.gameObject.transform.position.x);
            int y = (int)(coll.gameObject.transform.position.y);


            var zuch = Instantiate(zucchini, new Vector2(x, y), Quaternion.identity);

            Destroy(coll.gameObject);
            zuch.GetComponent<zucchini>().gravestone = true;
            ZFPIsTure = false;
        }
        else if (coll.name.StartsWith("ZFlowerPrefab(Clone)"))
        {
            ZFPIsTure = true;
            Destroy(coll.gameObject);
        }
    }
}
