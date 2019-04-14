using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText2 : MonoBehaviour
{
    public GameObject text; // the text you want to appear on screen
    public GameObject TriggerObject; //the object or player you want to trigger the text display
    public string TagName;
    public float TimeOut = 5f;
	// Use this for initialization
	void Start ()
    {
        text.SetActive(false);	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider TriggerObject)
    {
        if (TriggerObject.gameObject.tag == TagName) //Tag name of trigger Object. MUST BE EXACTLY THE SAME AS WHAT YOU PUT IN BETWEEN THE QUOTES
            //You may change the tag name but make sure the tag in unity matches this one or else it won't work
        {
            text.SetActive(true);
            StartCoroutine("WaitForSec");
        }
	}
    IEnumerator WaitForSec() // Delay before Text disappears from view
    {
        yield return new WaitForSeconds(TimeOut); //time text appears on screen
        text.SetActive(false);
    }
}
