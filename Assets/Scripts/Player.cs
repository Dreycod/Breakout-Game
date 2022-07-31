using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    [SerializeField] float BarSpeed = 10f;

    Rigidbody2D myRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BarMovement();
    }

    private void BarMovement()
    {
        float controlthrow = CrossPlatformInputManager.GetAxis("Horizontal");

        Vector2 playerVelocity = new Vector2(controlthrow * BarSpeed, 0);
        myRigidBody.velocity = playerVelocity;
    }
}
