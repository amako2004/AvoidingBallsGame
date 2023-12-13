using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Object;
    public GameObject ReturnObject;
    float yRotate = 1f;
    [SerializeField] float rotateSpeed = 50f;
    float xFirstRotation;
    float yFirstRotation;
    float zFirstRotation;


    // Start is called before the first frame update
    void Start()
    {
        xFirstRotation = GetComponent<Transform>().rotation.x;
        yFirstRotation = GetComponent<Transform>().rotation.y;
        zFirstRotation = GetComponent<Transform>().rotation.z;

    }

    // Update is called once per frame
    void Update()
    {
        ToRotate();
        ReturnObjectRotation();
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

    public void ReturnObjectRotation()
    {
        if (Input.GetKey(KeyCode.R) == true)
        {
            ReturnObject.transform.localEulerAngles = new Vector3(xFirstRotation, yFirstRotation, zFirstRotation);
        }

    }
}
