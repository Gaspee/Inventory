using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	//initialize num slots
	public const int numItemSlots = 4;
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];

	public void AddItem (Item item) {
		for (int i = 0; i < items.Length; i++) {
			if (items[i] == null) {
				items[i] = item;
				itemImages[i].sprite = item.sprite;
				itemImages[i].enabled = true;
				return;
			}
		}
	}

	public void RemoveItem (Item item)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == item)
			{
				items[i] = null;
				itemImages[i].sprite = null;
				itemImages[i].enabled = false;
				return;
			}
		}
	}

}
