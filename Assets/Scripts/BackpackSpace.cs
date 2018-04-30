using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackSpace : MonoBehaviour {

	public Button[] amountOfSpace;

	void Awake() {
		amountOfSpace = GetComponentsInChildren<Button>();
	}
}
