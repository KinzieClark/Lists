using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

	public List<string> myWeaponList; //lists are not a function, but an object, and are updated arrays. They can change
	public string[] myWeaponArray;

	// Use this for initialization
	void Start () {
		myWeaponList.Add("Sword");
	//	myWeaponList.Remove("Axe");
		myWeaponList.Add("Bow");
	//	myWeaponList.RemoveAt(1);
	}
	public void AddtoList () {
		myWeaponList.Add("Rock");
	}
}
