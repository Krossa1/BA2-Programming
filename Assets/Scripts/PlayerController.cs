using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterControllerRef;
    private Vector3 moveDirection;
    public float moveSpeed;


    //Awake executes before Start -> Awake references, Start for variables
    void Awake()
    {
        characterControllerRef = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) { moveDirection.z += 1; }
        if (Input.GetKey(KeyCode.S)) { moveDirection.z += -1; }
        if (Input.GetKey(KeyCode.A)) { moveDirection.x += -1; }
        if (Input.GetKey(KeyCode.D)) { moveDirection.x += 1; }

        moveDirection *= Time.deltaTime * moveSpeed;

        characterControllerRef.Move(moveDirection);
    }
}
