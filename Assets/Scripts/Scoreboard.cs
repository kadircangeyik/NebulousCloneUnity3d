using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoreboard : MonoBehaviour
{

	public string[] FirstNameArray;
	public string[] SecondNameArray1;
	public string[] SecondNameArray2;
	public string[] SecondNameArray3;
	public string[] SecondNameArray4;
	public string[] SecondNameArray5;
	public string[] SecondNameArray6;
	public string[] SecondNameArray7;
	public string FirstName;
	public string SecondName1;
	public string SecondName2;
	public string SecondName3;
	public string SecondName4;
	public string SecondName5;
	public string SecondName6;
	public string SecondName7;
	public Text FirstNameText;
	public Text SecondNameText1;
	public Text SecondNameText2;
	public Text SecondNameText3;
	public Text SecondNameText4;
	public Text SecondNameText5;
	public Text SecondNameText6;
	public Text SecondNameText7;

	void Start()
	{
		FirstName = FirstNameArray[Random.Range(0, FirstNameArray.Length)];
		SecondName1= SecondNameArray1[Random.Range(0, SecondNameArray1.Length)];
		SecondName2= SecondNameArray2[Random.Range(0, SecondNameArray2.Length)];
		SecondName3 = SecondNameArray3[Random.Range(0, SecondNameArray3.Length)];
		SecondName4 = SecondNameArray4[Random.Range(0, SecondNameArray4.Length)];
		SecondName5 = SecondNameArray5[Random.Range(0, SecondNameArray5.Length)];
		SecondName6 = SecondNameArray6[Random.Range(0, SecondNameArray6.Length)];
		SecondName7 = SecondNameArray7[Random.Range(0, SecondNameArray7.Length)];


		FirstNameText.text = FirstName.ToString();
		SecondNameText1.text = SecondName1.ToString();
		SecondNameText2.text = SecondName2.ToString();
		SecondNameText3.text = SecondName3.ToString();
		SecondNameText4.text = SecondName4.ToString();
		SecondNameText5.text = SecondName5.ToString();
		SecondNameText6.text = SecondName6.ToString();
		SecondNameText7.text = SecondName7.ToString();
	}
}