using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;

    public float rotationSpeed = 1.0f;

    public float movementSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0,0, rotationSpeed * Time.deltaTime);
        }
    }
     void OnCollisionEnter2D (Collision2D otherObject)
    {
        Debug.Log("[Collision Entered]The GameObject of the other object is named: " + otherObject.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D otherObject)
    {
        Debug.Log("[Collision Exited]The GameObject of the other object is named: " + otherObject.gameObject.name);
    }
    public void Shoot()
    {
        throw new NotImplementedException();
    }
    void OnDestroy()
    {
        // if the player dies, lose a life.
        GameManager.instance.lives -= 1;
        if (GameManager.instance.lives > 0)
        {
            GameManager.instance.Respawn();
        }
        else
        {
            Debug.Log("Gameover");
        }
    }
}
