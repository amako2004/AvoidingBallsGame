using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    GameObject invisibleObject;
    int hitCount = 0;
    int life = 10;
    int untilGameOver = 0;
    // Start is called before the first frame update
    void Start()
    {
        invisibleObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Guardian")
        {

            invisibleObject.SetActive(false);

        }
        else if (collision.gameObject.tag == "Player")
        {
            invisibleObject.SetActive(false);
            hitCount++;
            untilGameOver = life - hitCount;
            Debug.Log("untilGameOver-" + untilGameOver);
        }



    }

}
