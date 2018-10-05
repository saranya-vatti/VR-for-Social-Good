using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPileController : MonoBehaviour {

    private PlayerController playerControllerScript;
    public GameObject uiObject;


    // Use this for initialization
    void Start()
    {
        playerControllerScript = GameObject.Find("FirstPersonCharacter").GetComponent<PlayerController>();
        uiObject.SetActive(false);
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
            playerControllerScript.UpdateStats(1, 100);
        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        uiObject.SetActive(false);
        Destroy(gameObject);
        Destroy(uiObject);
    }
}
