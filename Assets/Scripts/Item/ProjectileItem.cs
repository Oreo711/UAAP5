using UnityEngine;

public class ProjectileItem : Item
{
	[SerializeField] private Projectile _projectilePrefab;

	public override void Use ()
	{
		IDirectable collector = Collector.GetComponent<IDirectable>();

		if (collector != null)
		{
			Projectile projectile = Instantiate(_projectilePrefab, Collector.transform.position, Quaternion.identity);
			projectile.Launch(collector.Direction);
		}

		base.Use();
	}
}
