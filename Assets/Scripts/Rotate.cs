using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Object;
    float yRotate = 1f;
    [SerializeField] float rotateSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ToRotate();
    }

    private void ToRotate()
    {
        if (Input.GetMouseButton(0) == true)
        {
            Object.transform.Rotate(0, -yRotate * Time.deltaTime * rotateSpeed, 0);
        }

        if (Input.GetMouseButton(1) == true)
        {
            Object.transform.Rotate(0, yRotate * Time.deltaTime * rotateSpeed, 0);
        }
    }
}
