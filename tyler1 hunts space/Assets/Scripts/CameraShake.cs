using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shake = 0;
    float shakeAmount = 0.7f;
    float decreaseFactor = 1.0f;
    Vector3 startPos;

    private void Start()
    {
        startPos = transform.localPosition;
    }
    
    void Update() 
    {
        if (shake > 0) 
        {
            var rand = Random.Range(-1*shakeAmount, shakeAmount);
            transform.localPosition = new Vector3(transform.localPosition.x+rand, transform.localPosition.y, transform.localPosition.z+rand);
            shake -= Time.deltaTime * decreaseFactor;
        } 
        else 
        {
            shake = 0.0f;
            transform.localPosition = startPos;
        }
    }

    public void ShakeCamera()
    {
        shake = 2.25f;
    }
}
