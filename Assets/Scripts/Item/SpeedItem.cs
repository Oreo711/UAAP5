using UnityEngine;

public class SpeedItem : Item
{
    [SerializeField] private float _speedBoost;

    public override void Use ()
    {
        Player player = Collector.GetComponent<Player>();

        if (player)
        {
            player.BoostSpeed(_speedBoost);
        }

        base.Use();
    }
}
