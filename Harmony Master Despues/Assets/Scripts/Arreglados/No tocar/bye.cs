using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bye : MonoBehaviour
{
    private float tiempo;

    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 1)
        {
            Destroy(gameObject);
        }
    }
}
