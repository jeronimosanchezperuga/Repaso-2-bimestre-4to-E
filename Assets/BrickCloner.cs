using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xOffset;
    public float userOffsetFloat;
    public Text userOffset;
    int counter = 0;

    public void CloneBrick()
    {
        if(counter == 0){
            userOffsetFloat = float.Parse(userOffset.text, System.Globalization.CultureInfo.InvariantCulture);
            xOffset = userOffsetFloat;
        }

        if (counter < 5)
        {
            GameObject clon;
            clon = Instantiate(brickPrefab);
            clon.transform.position += new Vector3(xOffset, 0, 0);
            xOffset += userOffsetFloat;
            counter++;
        }
    }
}
