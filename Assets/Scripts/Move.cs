using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
    float xPositon = 0;
    float zPositon = 0;

    // Start is called before the first frame update
    void Start()
    {
        //ReturnObject = ReturnObject.GetComponent<Rotate>().ReturnObject;
    }

    // Update is called once per frame
    void Update()
    {
        ToMove();
    }

    private void ToMove()
    {
        xPositon = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zPositon = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xPositon, 0, zPositon);
    }


}
