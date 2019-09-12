using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFadeAnim : MonoBehaviour {
    public Animator optionsanim;
    public Animator txtanim;
    public Animator  backanim;
    public Animator saveAnim;
    public Animator msTextAnim;
  
    // Use this for initialization
    void Start () {
		
	}
	public void Show()
    {
        optionsanim.SetBool("ON",true);
        backanim.SetBool("ON", true);
        txtanim.SetBool("ON",true);
        saveAnim.SetBool("ON", true);
        msTextAnim.SetBool("ON", true);

    }
    public void Hide()
    {
        optionsanim.SetBool("ON",false);
        txtanim.SetBool("ON", false);
        backanim.SetBool("ON",false);
        saveAnim.SetBool("ON", false);
        msTextAnim.SetBool("ON",false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
