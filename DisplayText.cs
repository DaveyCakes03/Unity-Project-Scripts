using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    public GameObject text;
	// Use this for initialization
	void Start ()
    {
        text.SetActive(false);	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider player)
    {
		if (player.gameObject.tag == "Player")
        {
            text.SetActive(true);
            StartCoroutine("WaitForSec");
        }
	}
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        text.SetActive(false);
    }
}
