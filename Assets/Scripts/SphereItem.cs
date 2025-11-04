using UnityEngine;

public class SphereItem : Item
{
	[SerializeField] private Projectile _projectilePrefab;

	public override void Use ()
	{
		Projectile projectile = Instantiate(_projectilePrefab, _player.transform.position, Quaternion.identity);
		projectile.Initialize(_player.MoveDirection);

		base.Use();
	}
}
