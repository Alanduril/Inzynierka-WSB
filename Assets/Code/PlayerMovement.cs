using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontalMovement=5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed= Input.GetAxis("Horizontal")*horizontalMovement*Time.deltaTime;
        transform.Translate(movementSpeed,0,0);
    }
}
