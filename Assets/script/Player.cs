using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movespeed;
    Rigidbody2D rigibody;
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigibody.linearVelocity = new Vector2(-2f, 0f);

        }
        else
        {
        }
    }
}
