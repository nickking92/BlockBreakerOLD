using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle;
     [SerializeField] AudioClip[] ballSounds;
     bool hasStarted=false;
    Vector2 paddleToBallDistance;
    AudioSource myAudioSource;
	void Start () {
        paddleToBallDistance = transform.position-paddle.transform.position;
        myAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
            LockBallToPaddle();
        LaunchBallOnClick();
        
    }

    private  void LaunchBallOnClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(10f,10f);
        }
    }
    
    private void LockBallToPaddle()
    {
        
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallDistance;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            AudioClip clip = ballSounds[Random.Range(0,ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}
