using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour {
	public Item item;

	public string itemName;
	public string itemType;
	public Image itemSprite;
	public Sprite socketSprite;
	public int amountOfSockets;

	[SerializeField] Image[] snapPoints;

	Canvas myCanvas;

	void Awake() {
		myCanvas = FindObjectOfType<Canvas>();

		itemName = item.name;
		itemType = item.type;
		itemSprite.sprite = item.itemSprite;

		amountOfSockets = item.amountOfSockets;
	}

	void Update() {
         Vector2 pos;
         RectTransformUtility.ScreenPointToLocalPointInRectangle(myCanvas.transform as RectTransform, Input.mousePosition, myCanvas.worldCamera, out pos);

		if((Input.GetMouseButton(0))) {
			transform.position = myCanvas.transform.TransformPoint(pos);
		}
	}

}
