using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnMino : MonoBehaviour
{
    public GameObject[] Minos;
    public GameObject Spawn;
    // Start is called before the first frame update
    public void Start()
    {
        NewMino();
    }

    public void NewMino()
    {
        Instantiate(Minos[Random.Range(0, Minos.Length)], transform.position, Quaternion.identity);
    }

    public void GameOver()
    {
        Spawn.active = false;
    }
}