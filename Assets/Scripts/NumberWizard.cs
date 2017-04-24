using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("-= Welcome to Number Wizard =-");
        print("Pick a number in your head but don't tell me.");

        const int MAX = 1000;
        const int MIN = 1;

        print("The number you choose must be between " + MIN.ToString() + " and "+ MAX.ToString() + ".");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
