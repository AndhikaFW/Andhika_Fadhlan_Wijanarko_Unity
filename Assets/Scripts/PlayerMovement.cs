using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour {

    [SerializeField]
    private Vector2 maxSpeed
    [SerializeField]
    private Vector2 timeToFullSpeed
    [SerializeField]
    private Vector2 timeToStop
    [SerializeField]
    private Vector2 stopClamp
    private Vector2 moveDirection
    private Vector2 moveVelocity
    private Vector2 moveFriction
    private Vector2 stopFriction
    private Rigidbody2D rb
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Move()
    {
        
    }

    Vector2 GetFriction()
    {

    }

    void MoveBound()
    {

    }

    bool IsMoving()
    {

    }
}
