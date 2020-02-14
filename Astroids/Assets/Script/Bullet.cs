using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform tf;
    public float bulletSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //always move forward
        tf.position += tf.right * bulletSpeed * Time.deltaTime;
    }
}
