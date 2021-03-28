using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piranhaSpawn : MonoBehaviour
{

    public GameObject piranhaMon;
    public float xPos;
    public float yPos;
    public int piranhaCount;


    void Start()
    {
        StartCoroutine(PiranhaSpawn());
    }

    IEnumerator PiranhaSpawn() {
        while (piranhaCount < 6)
        {
            xPos = Random.Range(7.2f, 13f);
            yPos = Random.Range(-2f, 1f);
            Instantiate(piranhaMon, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.6f);
            piranhaCount += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
