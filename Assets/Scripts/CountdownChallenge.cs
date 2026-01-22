using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CountdownChallenge : MonoBehaviour
{
    private float timer = 0.0f;
    private float waitTime = 1.0f;
    //private int counter = 10;
    private float startSeconds = 10.0f;
    private GameObject capsuleAsset;
    private MeshRenderer capsuleRender;
    void Start()
    {
        capsuleAsset = GameObject.Find("capsule");
        capsuleRender = capsuleAsset.GetComponent<MeshRenderer>();
        Debug.Log("Time left: " + startSeconds);
    }
    
    void Update()
    {
        timer += Time.deltaTime;

        if (startSeconds > 0)
        {
            if (timer > waitTime)
            {
                capsuleRender.enabled = !capsuleRender.enabled;

                timePassedMessage();
                timer = 0.0f;
            }
        }
    }

    void timePassedMessage()
    {
        startSeconds--;

        if (startSeconds == 0)
        {
            Debug.Log("TIMES UP");
        }
        else
        {
            Debug.Log("Time left: " + startSeconds);
        }
    }
}
