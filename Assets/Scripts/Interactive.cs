using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Interactive : MonoBehaviour
{
    [SerializeField]
    Canvas messageCanvas;
    [SerializeField]
    Canvas messageCanvasS;
    [SerializeField]
    Canvas messageCanvasZ;
    public bool eaten;

    void Start()
    {
        messageCanvas.enabled = false;
        messageCanvasS.enabled = false;
        messageCanvasZ.enabled = false;
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
        else if (other.name == "SFlowerPrefab(Clone)")
        {
            TurnOnMessageS();
        }
        else if (other.name == "SPrefab(Clone)")
        {
            TurnOnMessageS();
        }
        else if (other.name == "ZFlowerPrefab(Clone)")
        {
            TurnOnMessageZ();
        }
        else if (other.name == "ZPrefab(Clone)")
        {
            TurnOnMessageZ();
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
        else if (other.name == "SFlowerPrefab(Clone)")
        {
            TurnOffMessage();
        }
        else if (other.name == "SPrefab(Clone)")
        {
            TurnOffMessage();
        }
        else if (other.name == "ZFlowerPrefab(Clone)")
        {
            TurnOffMessage();
        }
        else if (other.name == "ZPrefab(Clone)")
        {
            TurnOffMessage();
        }
    }

    public void TurnOffMessage()
    {
        messageCanvas.enabled = false;
        messageCanvasS.enabled = false;
        messageCanvasZ.enabled = false;
    }

    void TurnOnMessageS()
    {
        messageCanvasS.enabled = true;
    }
    void TurnOnMessageZ()
    {
        messageCanvasZ.enabled = true;
    }
}