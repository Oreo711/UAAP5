using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Random = UnityEngine.Random;


public class ItemSpawner : MonoBehaviour
{
	[SerializeField] private List<Item> _itemPrefabs;
	[SerializeField] private float      _cooldown = 5f;

	private float   _currentCooldown;
	private bool    IsOccupied;
	private Item    _currentItem;
	private Vector3 _offset = new Vector3(0, 1, 0);

	private void Awake ()
	{
		ResetCooldown();
	}

	private void ResetCooldown ()
	{
		_currentCooldown = _cooldown;
	}

	private void Update ()
	{
		if (_currentItem)
		{
			IsOccupied = true;
		}
		else
		{
			_currentCooldown -= Time.deltaTime;
			IsOccupied = false;
		}

		SpawnItem();

		if (_currentCooldown <= 0)
		{
			ResetCooldown();
		}
	}

	private void SpawnItem ()
	{
		if (IsOccupied || _currentCooldown > 0)
		{
			return;
		}

		Item itemPrefab = _itemPrefabs[Random.Range(0, _itemPrefabs.Count)];

		Item item = Instantiate(itemPrefab, transform.position + _offset, Quaternion.identity);
		_currentItem = item;
	}
}
