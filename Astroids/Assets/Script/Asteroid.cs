using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.enemieslist.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
    {
        GameManager.instance.enemieslist.Remove(this.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D OtherObject)
    {
        Destroy(OtherObject.gameObject);
        Destroy(this.gameObject);
    }
}
