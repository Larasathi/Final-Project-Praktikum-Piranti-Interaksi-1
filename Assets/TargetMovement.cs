using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour {

    public float xPos;
    public float yVel;
    public float xVel;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        xPos = Random.Range(-8, 8);
        yVel = Random.Range(9, 13);
        xVel = Random.Range(-3, 3);

        if (this.transform.position.y < -3)
        {
            this.transform.position = new Vector2(xPos, -3);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        }
	}
    


    public void OnMouseDown()
    {
        Debug.Log("clicked");
        Destroy(this.gameObject);
        //Instantiate(this.gameObject);
    }
}
