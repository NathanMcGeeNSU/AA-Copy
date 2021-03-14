using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    public static string playernamestr;

    public Text playername;

    void Start ()
    {
        playername.text = playernamestr;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPin();
        }
    }

    void SpawnPin ()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
