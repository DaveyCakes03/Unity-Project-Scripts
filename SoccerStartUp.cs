using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerStartUp : MonoBehaviour
{
    // text = "You Chose ___ Team! The Game Will Begin In 10 Seconds!"
    // text2 = "Go!"
    // count# = Count Down Number

    public GameObject text; // the text you want to appear on screen
    public GameObject text2;

    public GameObject count5; // count down
    public GameObject count4;
    public GameObject count3;
    public GameObject count2;
    public GameObject count1;

    public GameObject OtherOption; // the other trigger collider option... duh!

    public GameObject TriggerObject; //the object or player you want to trigger the text display
    public string TagName;


    public GameObject Wall1;
    public GameObject Wall2;

    public GameObject BallBox;
	// Use this for initialization
	void Start ()
    {

        text.SetActive(false);      //Making Sure All the Text is not visable until trigger
        text2.SetActive(false);

        count5.SetActive(false);
        count4.SetActive(false);
        count3.SetActive(false);
        count2.SetActive(false);
        count1.SetActive(false);

    }
	
	// Update is called once per frame
	void OnTriggerEnter (Collider Player)
    {
		if (TriggerObject.gameObject.tag == TagName) //Tag name of trigger Object. MAKE SURE THAT THE TAG NAME IS THE SAME AS THE NAME OF THE TAG ON YOUR TRIGGER OBJECT, OTHERWISE IT WON'T WORK
            
        {
            text.SetActive(true);
            StartCoroutine("WaitForSec");
        }
	}
    IEnumerator WaitForSec() // Delay before Text disappears from view
    {
        yield return new WaitForSeconds(5); // After 5 sec text disappears
        text.SetActive(false);

        count5.SetActive(true);
        yield return new WaitForSeconds(1); // 5 sec Countdown begins
        count5.SetActive(false);

        count4.SetActive(true);
        yield return new WaitForSeconds(1);
        count4.SetActive(false);

        count3.SetActive(true);
        yield return new WaitForSeconds(1);
        count3.SetActive(false);

        count2.SetActive(true);
        yield return new WaitForSeconds(1);
        count2.SetActive(false);

        count1.SetActive(true);
        yield return new WaitForSeconds(1);
        count1.SetActive(false);

        text2.SetActive(true); // "GO!" Displays

        yield return new WaitForSeconds(1); //time text appears on screen
        text2.SetActive(false); //"Go!" Leaves Screen

        Destroy(Wall1); //Walls go down and game begins
        Destroy(Wall2);

        Destroy(OtherOption);
        Destroy(BallBox);
        Destroy(gameObject);
    }
}
