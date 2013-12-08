using UnityEngine;
using System.Collections;

public class MakeProgress : MonoBehaviour {
    public UISlider slider;
    public UILabel label;

    private float _sliderWidth;

	// Use this for initialization
	void Awake () {
        _sliderWidth = slider.foreground.localScale.x;
	}
	
	// Update is called once per frame
	public void UpdateProgress (float per) {
        Vector3 localScale = slider.foreground.localScale;
        slider.foreground.localScale = new Vector3(_sliderWidth * per, localScale.y, localScale.z);
	}

    public void SetText(string str)
    {
        label.text = str;
    }

    public bool LabelVisible
    {
        set
        {
            label.enabled = value;
        }
    }
}
