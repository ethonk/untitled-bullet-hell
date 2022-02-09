using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private CharacterController control;
    [SerializeField]
    private float defaultSpeed;
    private float speed;
    private bool focus;

    private void Start()
    {
        control = gameObject.GetComponent<CharacterController>();
    }

    void Move2(Vector3 moveVector)
    {
        control.Move(moveVector * Time.deltaTime * speed);
    }

    void Update()
    {
        Vector3 moveVector = new Vector3(0, 0);

        // Focus
        if(Input.GetKey(KeyCode.LeftShift))
            focus = true;
        else
            focus = false;    

        speed = defaultSpeed;
        if(focus)
        {
            speed /= 2;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            Move2(new Vector3(0, 1));
        if (Input.GetKey(KeyCode.DownArrow))
            Move2(new Vector3(0, -1));
        if (Input.GetKey(KeyCode.LeftArrow))
            Move2(new Vector3(-1, 0));
        if (Input.GetKey(KeyCode.RightArrow))
            Move2(new Vector3(1, 0));
    }
}
