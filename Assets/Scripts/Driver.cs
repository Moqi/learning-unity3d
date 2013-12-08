using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
    public MakeProgress makeProgress;
    public int curValue;
    public int maxValue;
    public bool labelVisible;
	
	// Update is called once per frame
	void OnClick () {
        makeProgress.LabelVisible = labelVisible;
        makeProgress.SetText(curValue.ToString() + "/" + maxValue.ToString ());
        makeProgress.UpdateProgress(curValue / (float)maxValue);
	}
}
