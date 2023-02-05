using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canPress = true;

    private void Start()
    {
        InvokeRepeating("TimePassed", 0, 1);
    }


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canPress == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canPress = false;
        }
    }

    void TimePassed()
    {
        // On spacebar press, send dog
        canPress = true;
    }

}
