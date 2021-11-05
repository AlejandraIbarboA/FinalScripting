using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObrDestruction : MonoBehaviour
{
    [SerializeField] GameObject orbHP;
    public delegate void orbDestruction();
    public event orbDestruction destroyed;

    void Update()
    {
        if (orbHP == null)
        {
            destroyed.Invoke();
        }
    }
}