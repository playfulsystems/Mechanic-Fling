using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlingUI : MonoBehaviour
{
    public Text flingText;
    public IntVariable flingNum;

	private void Update()
	{
		flingText.text = flingNum.value.ToString();
	}
}
