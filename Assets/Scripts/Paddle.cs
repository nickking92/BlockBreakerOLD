using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //[SerializeField] float screenwidthInUnits = 28f;
    //[SerializeField] float screenheightInUnits = 16f;
    private Camera cam;

    public float minX, maxX;

    void Start()
    {
        this.cam = Camera.main; // we cache Camera.main for reasons of performance
      
    }

    // Update is called once per frame
    void Update()
    {
        OMove();

    }
    void OMove()
    {
        Vector3 paddlePos = this.transform.position;
        float mousePosInBlocks = this.cam.ScreenToWorldPoint(Input.mousePosition).x;
       // Debug.Log(this.cam.ScreenToWorldPoint(Input.mousePosition).x);
        this.transform.position = new Vector3(mousePosInBlocks, paddlePos.y, paddlePos.z);

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        transform.position = paddlePos;

    }
}
