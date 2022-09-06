using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfShotsUI : MonoBehaviour
{
    public IntVariable flingNum;
    public Text outOfShots;

    // Update is called once per frame
    void Update()
    {
        if (flingNum.value > 4)
		{
            outOfShots.enabled = true;
        }
    }
}
