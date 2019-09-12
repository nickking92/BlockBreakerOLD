using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnimation : MonoBehaviour {

    public Animator fadeAnim;
	void Start () {
        fadeAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void FadeIn()
    {
        fadeAnim.SetBool("ON", true);
    }
    public void FadeOut()
    {
        fadeAnim.SetBool("ON", false);
    }
}
