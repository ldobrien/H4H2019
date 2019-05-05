using UnityEngine;
using System.Collections;
public class Interactive : MonoBehaviour
{
    [SerializeField]
    Canvas messageCanvas;
    public bool eaten;

    void Start()
    {
        messageCanvas.enabled = false;
        eaten = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (eaten)
        {
            TurnOffMessage();
            eaten = false;
        }
        else if (other.name == "FlowerPrefab(Clone)")
        {
            TurnOnMessage();
        }
    }

    private void Update()
    {
        if (eaten)
        {
            TurnOffMessage();
        }
    }

    private void TurnOnMessage()
    {
        messageCanvas.enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "FlowerPrefab(Clone)")
        {
            TurnOffMessage();
        }
    }

    public void TurnOffMessage()
    {
        messageCanvas.enabled = false;
    }
}