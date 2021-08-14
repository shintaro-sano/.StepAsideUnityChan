using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPrefabScript : MonoBehaviour
{
    private GameObject unitychanText;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychanText = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= unitychanText.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}