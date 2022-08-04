using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Vector2 InitialForce;
    [SerializeField] float MaxSpeed;
    Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myRigidBody.velocity = InitialForce;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        SpeedControl();
    }
    void SpeedControl()
    {
         // Trying to Limit Speed
         myRigidBody.velocity = Vector2.ClampMagnitude(myRigidBody.velocity, MaxSpeed);
    }
}
