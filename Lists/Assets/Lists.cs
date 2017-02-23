using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

//	public List<string> myWeaponsList;
//	public List<string> myItemsList;
	public List<string> myFlowersList;

	// Use this for initialization
//	void Start () {
//		myWeaponsList.Add("Sword"); //Will add a fourth element called "Sword"
//		myWeaponsList.Remove("Axe"); //Will remove the element called "Axe"
   	//	myWeaponsList.Add("Bow"); //Will create, again, a fourth element, called "Bow"
  	//	myWeaponsList.RemoveAt(1); //Will remove whatever the first element is regardless
//	}
//	void Start () {
//		myItemsList.Add("Health Booster");
//		myItemsList.Add("Tome");
//		myItemsList.Remove("Stat Booster");
//	}
	void Start () {
		myFlowersList.Add("Tiger lillies");
		myFlowersList.RemoveAt(2);
		myFlowersList.Add("Daffodils");
	}
}
