using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zucchini : MonoBehaviour
{
    [HideInInspector]
    public bool gravestone = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (gravestone)
        {
            Destroy(this.gameObject, 3);
        }
    }
}
