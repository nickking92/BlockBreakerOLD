using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderAnim : MonoBehaviour {
    public Animator anim;
    public Animator anim2;
    // Use this for initialization
    void Start () {
    
	}

   public void  ShowSlider()
    {
        anim.SetBool("ON",true);
        anim2.SetBool("ON", true);
    }
    public void HideSlider()
    {
        anim.SetBool("ON",false);
        anim2.SetBool("ON",false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
