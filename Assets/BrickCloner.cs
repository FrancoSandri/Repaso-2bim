using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xOffset;
    int counter = 0;
    public Text userOffset;


    public void CloneBrick()
    {
        if(counter == 0)
        {
            xOffset = float.Parse(userOffset.text);
        }

        if (counter < xOffset)
        {
            GameObject clon;
            clon = Instantiate(brickPrefab);
            clon.transform.position = new Vector3(float.Parse(userOffset.text), 0, 0);
            xOffset += 1.1f;
            counter++;
        }
    }
}
