using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearance : MonoBehaviour
{
    public GameObject AppearancePrefab;
    [SerializeField] float appearanceFrequency = 5f;
    float time;
    float xPrefabPosition;
    float zPrefabPosition;
    Vector3 placeOfAppearance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        appearance();
    }

    void appearance()
    {
        if (time >= appearanceFrequency)
        {
            getPrefabPosition();
            Instantiate(AppearancePrefab, placeOfAppearance, Quaternion.identity);
            time = 0;
        }

    }

    void getPrefabPosition()
    {
        xPrefabPosition = Random.Range(-16f, 16f);
        zPrefabPosition = Random.Range(-15f, 18f);
        placeOfAppearance = new Vector3(xPrefabPosition, 1.25f, zPrefabPosition);
    }
}
