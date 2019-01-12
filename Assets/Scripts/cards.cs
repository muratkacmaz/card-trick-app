using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cards : MonoBehaviour {
	public Sprite[] cardsprites; 
	public Sprite[]	colorsprites ;
	public GameObject card ;
	public GameObject cardBack;  
	public GameObject photoButton ;
	public GameObject animButton ;
	// Use this for initialization
	int s ;
	int c ;
	int renk ;

	void Start () {
		s = PlayerPrefs.GetInt ("suits");
		c = PlayerPrefs.GetInt("cardNumber");
		renk = PlayerPrefs.GetInt ("color");

		int elementNumber;

		elementNumber = 13 * (s - 1) + c - 1;


		card.GetComponent<SpriteRenderer> ().sprite = cardsprites [elementNumber];

		cardBack.GetComponent<SpriteRenderer>().sprite = colorsprites[renk-1];

	}


	
	public void BackB (){
		Application.LoadLevel ("openingScene");
	}


		
}
