using UnityEngine;
using UnityEngine.SceneManagement;

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
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(worldPos.x < 0)
            {
                rigibody.AddForce(Vector2.left * movespeed);
            }
            else
            {
                rigibody.AddForce(Vector2.right * movespeed);
            }
            //rigibody.linearVelocity = new Vector2(5, 0);



        }
        else
        {
            rigibody.linearVelocity = Vector2.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "block")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
