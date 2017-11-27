using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public float gravityScaleModifier = 20f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1f+Time.timeSinceLevelLoad / gravityScaleModifier;
    }

    // Update is called once per frame
    void Update () {
        if (transform.position.y < -2f){
            Destroy(gameObject);
        }
	}
}
