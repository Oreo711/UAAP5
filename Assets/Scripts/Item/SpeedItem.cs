using UnityEngine;

public class SpeedItem : Item
{
    [SerializeField] private float _speedBoost;

    public override void Use ()
    {
        if (Player)
        {
            Player.BoostSpeed(_speedBoost);
        }

        base.Use();
    }
}
