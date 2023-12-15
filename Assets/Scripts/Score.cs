using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    int hitCount = 0;
    int life = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pursuer")
        {
            hitCount++;
            Debug.Log((life - hitCount) + "more to fail");

        }
    }

    void checkScore()
    {
        if (life == hitCount)
        {
            Debug.Log("you've failed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
