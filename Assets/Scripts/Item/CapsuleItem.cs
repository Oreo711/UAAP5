using UnityEngine;

public class CapsuleItem : Item
{
    [SerializeField] private float _healthBoost;

    public override void Use ()
    {
        if (Player)
        {
            Player.BoostHealth(_healthBoost);
        }

        base.Use();
    }
}
