using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour {
    private UILabel _label;

    void Awake()
    {
        _label = GetComponent<UILabel>();
        Color = Color.red;
        Text = "good to go";
    }

    public Color Color
    {
        get
        {
            return _label.color;
        }
        set
        {
            _label.color = value;
        }
    }

    public string Text
    {
        get
        {
            return _label.text;
        }
        set
        {
            _label.text = value;
        }
    }
}
