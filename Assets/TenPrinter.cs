using UnityEngine;
using UnityEngine.UI;

using System.Collections;


public class TenPrinter : MonoBehaviour {

	GameObject screenTextField;

	string outPutText;

	public int rowLength = 50;
	public int maxNumberOfRows = 26;
	


	// Use this for initialization
	void Start () {

		screenTextField = GameObject.Find ("OutputTextField");

		outPutText = "";
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Random.Range (0, 2) == 0) {
			outPutText = outPutText + "/";
		}
		else
		{
			outPutText = outPutText + "\\";
		}

		if (outPutText.Length <= rowLength * maxNumberOfRows) {
		
			screenTextField.GetComponent<Text> ().text = outPutText; 
			
		} else {

			outPutText = outPutText.Substring(rowLength);

			screenTextField.GetComponent<Text> ().text = outPutText; 

		}

	}
}
