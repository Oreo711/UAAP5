using System;
using UnityEngine;
using UnityEngine.Serialization;


public class Player : MonoBehaviour
{
	[SerializeField] private float _speed = 5;
	[SerializeField] private float _health = 100f;

	public bool IsMoving {get; private set;} = false;
	public Vector3 MoveDirection {get; private set;}

	private readonly Mover _mover = new Mover();

	private float _deadZone = 0.1f;
	private Vector3 _input;

	public Item HeldItem {get; private set;}

	public void BoostSpeed (float boost)
	{
		_speed += boost;
		Debug.Log($"Your speed is now {_speed}!");
	}

	public void BoostHealth (float boost)
	{
		_health += boost;
		Debug.Log($"Your health is now {_health}!");
	}

	public void HoldItem (Item item)
	{
		HeldItem = item;
	}

	public void Enable ()
	{
		gameObject.SetActive(true);
		transform.position = Vector3.zero;
	}

	public void Disable ()
	{
		gameObject.SetActive(false);
	}

	private void Update()
	{
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		if (input.magnitude <= _deadZone)
		{
			IsMoving = false;
			_input = Vector3.zero;
			return;
		}

		Vector3 normalizedInput = input.normalized;
		MoveDirection = normalizedInput;
		_input   = normalizedInput;
		IsMoving = true;

	}

	private void FixedUpdate ()
	{
		_mover.MoveInDirection(gameObject, _input, _speed);
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
			item.Collect();
		}
	}
}
