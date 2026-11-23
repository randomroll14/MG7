using System;
using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] sparrows;
    [SerializeField] private GameObject player;
    [SerializeField] private float interactionDistance;

    private void Update()
    {
        for(int i = 0; i < sparrows.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, sparrows[i].transform.position) < interactionDistance)
            {
                sparrows[i].SetActive(true);
            }
        }
    }
}
