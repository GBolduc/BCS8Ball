using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour {
    string[] phrases = new string[]
    {
        "Google It!",
"#prayforscale",
"Segfault :(",
"Trust the natural recursion!",
"*Throws computer out window*",
"Computer says no.",
"The files are INSIDE the computer.",
"You should know this. *Assumes you have 2yrs Dev experience*",
"Seems fine.",
"EVERYTHING IS BAD.",
"It works! I don't know why...",
"Throw ThisSucksError"
    };
    public Text phraseBox;

    public Button m_Button;
	// Use this for initialization
	void Start () {
        Button btn1 = m_Button;
        btn1.onClick.AddListener(taskOnClick);
		
	}
    void taskOnClick() {
        int index = Random.Range(0, phrases.Length);
        phraseBox.text = phrases[index];


    }
    // Update is called once per frame
    void Update () {
		
	}
}
