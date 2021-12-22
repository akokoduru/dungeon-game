using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate() {
        //reset MoveDelta

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x,y,0);

        //Swap sprite direction, whether going right or left
        if(moveDelta.x > 0) {
            transform.localScale = Vector3.one;
        }
        else if(moveDelta.x < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //make it move!
        transform.Translate(moveDelta * Time.deltaTime);
    }
}
