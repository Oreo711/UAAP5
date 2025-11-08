using UnityEngine;

public class ProjectileItem : Item
{
	[SerializeField] private Projectile _projectilePrefab;

	public override void Use ()
	{
		if (Player)
		{
			Projectile projectile = Instantiate(_projectilePrefab, Collector.transform.position, Quaternion.identity);
			projectile.Launch(Player.MoveDirection);
		}

		base.Use();
	}
}
