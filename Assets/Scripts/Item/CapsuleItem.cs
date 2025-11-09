using UnityEngine;

public class CapsuleItem : Item
{
    [SerializeField] private float _healthBoost;

    public override void Use ()
    {
        Player player = Collector.GetComponent<Player>();

        if (player)
        {
            player.BoostHealth(_healthBoost);
        }

        base.Use();
    }
}
