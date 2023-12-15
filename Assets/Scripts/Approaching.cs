using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Approaching : MonoBehaviour
{
    float xTargetPosition;
    float yTargetPosition;
    float zTargetPosition;
    [SerializeField] int everyFewSeconds = 3;
    public GameObject TargetObject;
    float time;
    [SerializeField] float speed = 0.05f;
    Vector3 pursuers;
    Vector3 AfterPosition;

    // Start is called before the first frame update
    void Start()
    {
        pursuers = this.gameObject.transform.position;
        TargetObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        GetTargetPosition();
        ApproachingTarget();
    }

    public void GetTargetPosition()
    {
        if (time >= everyFewSeconds)
        {
            xTargetPosition = TargetObject.transform.position.x;
            yTargetPosition = TargetObject.transform.position.y;
            zTargetPosition = TargetObject.transform.position.z;
            AfterPosition = new Vector3(xTargetPosition, yTargetPosition, zTargetPosition);
            time = 0;
        }
    }

    private void ApproachingTarget()
    {
        pursuers = Vector3.MoveTowards(pursuers, AfterPosition, speed);
        this.gameObject.transform.position = pursuers;
    }
}
