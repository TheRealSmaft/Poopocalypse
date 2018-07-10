using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopMaster : MonoBehaviour {

    [SerializeField]
    private GameObject poopPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnPoop", .1f, 1f);
    }

    private void SpawnPoop()
    {
        GameObject poop = Instantiate(poopPrefab);
        poop.transform.position = new Vector3(Mathf.Floor(Random.Range(-20f, 20f)), Mathf.FloorToInt(Random.Range(20f, 30f)), Mathf.FloorToInt(Random.Range(-20f, 20f)));
        poop.transform.eulerAngles = new Vector3(Mathf.Floor(Random.Range(-180f, 180f)), Mathf.Floor(Random.Range(-180f, 180f)), Mathf.Floor(Random.Range(-180f, 180f)));
    }
}
