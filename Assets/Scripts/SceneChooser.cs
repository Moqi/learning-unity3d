using UnityEngine;
using System.Collections;

public class SceneChooser : MonoBehaviour {

	void ShowProgressScene()
    {
        Application.LoadLevel("Progress");
    }

    void DoSomethingElse()
    {
        print ("tell me what to do");
    }
}
