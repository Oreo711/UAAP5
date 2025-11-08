using System;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
	public Item HeldItem {get; private set;}

	public void HoldItem (Item item)
	{
		HeldItem = item;
	}

	private void Update ()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			HeldItem.Use();
		}
	}

	private void OnTriggerEnter (Collider other)
	{
		if (HeldItem)
		{
			return;
		}

		Item item = other.gameObject.GetComponent<Item>();

		if (item)
		{
			item.Initialize(gameObject);
			item.Collect();
		}
	}
}
