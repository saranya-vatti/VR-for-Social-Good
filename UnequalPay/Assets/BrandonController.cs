using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrandonController : MonoBehaviour {

    private PlayerController playerControllerScript;
    public GameObject uiObject;

    // Use this for initialization
    void Start()
    {
        uiObject.SetActive(false);
        playerControllerScript = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(8);
        uiObject.SetActive(false);
        playerControllerScript.UpdateStats(2, 200);
        Destroy(gameObject);
    }
}
