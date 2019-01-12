using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class opening : MonoBehaviour {
	// player prefs gameType 1 iken duz , 2 ters, 3 karalamalı 
	// plaer prefs suitleri 1 club , 2 diamond ,3 heart , 4 spade 

	public GameObject panel_opening, panel_trickSelect , panel_suits, panel_numbers , panel_tutorials , panel_colors, panel_info;



	void Start () {
		panel_opening.SetActive (true);
	}


	public void StartClicked(){
		panel_opening.SetActive (false);
		panel_trickSelect.SetActive (true);

	}

	public void tutorialsClicked(){
		panel_opening.SetActive (false);
		panel_tutorials.SetActive (true);
	}

	public void infoClicked(){
		panel_opening.SetActive (false);
		panel_info.SetActive (true);

	}




	public void Trick1Clicked(){
		PlayerPrefs.SetInt ("gameType", 1);
		panel_trickSelect.SetActive (false);
		panel_suits.SetActive (true);

	}


	public void Trick2Clicked(){
		PlayerPrefs.SetInt ("gameType", 2);
		panel_trickSelect.SetActive (false);
		panel_suits.SetActive (true);

	}



	public void clubsClicked(){
		PlayerPrefs.SetInt ("suits", 1);
		panel_suits.SetActive (false);
		panel_numbers.SetActive (true);
			
	

	}

	public void diamondsClicked(){
		panel_suits.SetActive (false);
		panel_numbers.SetActive (true);
		PlayerPrefs.SetInt ("suits", 2);
	}
	public void heartsClicked(){
		panel_suits.SetActive (false);
		panel_numbers.SetActive (true);
		PlayerPrefs.SetInt ("suits", 3);
	}

	public void spadesClicked(){
		panel_suits.SetActive (false);
		panel_numbers.SetActive (true);
		PlayerPrefs.SetInt ("suits", 4);
	}




	public void aceClicked(){	PlayerPrefs.SetInt ("cardNumber", 1);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void twoClicked(){	PlayerPrefs.SetInt ("cardNumber", 2);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void treeClicked(){	PlayerPrefs.SetInt ("cardNumber", 3);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void fourClicked(){	PlayerPrefs.SetInt ("cardNumber", 4);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void fiveClicked(){	PlayerPrefs.SetInt ("cardNumber", 5);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void sixClicked(){	PlayerPrefs.SetInt ("cardNumber", 6);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void sevenClicked(){	PlayerPrefs.SetInt ("cardNumber", 7);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void eightClicked(){	PlayerPrefs.SetInt ("cardNumber", 8);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void nineClicked(){	PlayerPrefs.SetInt ("cardNumber", 9);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void tenClicked(){	PlayerPrefs.SetInt ("cardNumber", 10);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void jackClicked(){	PlayerPrefs.SetInt ("cardNumber", 11);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}

	public void queenClicked(){	PlayerPrefs.SetInt ("cardNumber", 12);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
	} else {
		panel_numbers.SetActive (false);
		panel_colors.SetActive (true);
	}
	
	}

	public void kingClicked(){	PlayerPrefs.SetInt ("cardNumber", 13);
		if (PlayerPrefs.GetInt ("gameType") == 1) {
			Application.LoadLevel ("gameType1");
		} else {
			panel_numbers.SetActive (false);
			panel_colors.SetActive (true);
		}
	}



	public void redClicked(){	PlayerPrefs.SetInt ("color", 1);
		Application.LoadLevel ("gameType2");
	}

	public void grayClicked(){	PlayerPrefs.SetInt ("color", 2);
		Application.LoadLevel ("gameType2");}

	public void blueClicked(){	PlayerPrefs.SetInt ("color", 3);
		Application.LoadLevel ("gameType2");}

	public void greenClicked(){	PlayerPrefs.SetInt ("color", 4);
		Application.LoadLevel ("gameType2");}

	public void purpleClicked(){ PlayerPrefs.SetInt ("color", 5);
		Application.LoadLevel ("gameType2");}



	public void websiteClicked()  {
		Application.OpenURL ("http://worldpossible.co/");	
	}

	public void linkedClicked()  {
		Application.OpenURL ("https://www.linkedin.com/in/murat-kacmaz-75a194109?trk=nav_responsive_tab_profile_pic");	
	}

	public void firstTuto(){
		Application.OpenURL ("https://www.youtube.com/watch?v=LKxemGd6Seg");	
	}

	public void backButt(){
		panel_info.SetActive (false);
		panel_opening.SetActive (true);
	}

	public void backButt2(){
		panel_tutorials.SetActive (false);
		panel_opening.SetActive (true);
	}
}
				 