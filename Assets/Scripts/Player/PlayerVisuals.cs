using UnityEngine;

public class PlayerVisuals : MonoBehaviour
{
	[SerializeField] private Animator _animator;
	[SerializeField] private Player   _player;

	[SerializeField] private float _rotationSpeed;

	private readonly Mover _mover = new Mover();

	private void Update ()
	{
		_animator.SetBool("IsMoving", _player.IsMoving);

		if (_player.IsMoving)
		{
			_mover.LookInDirection(gameObject, _player.Direction, _rotationSpeed);
		}
	}
}
