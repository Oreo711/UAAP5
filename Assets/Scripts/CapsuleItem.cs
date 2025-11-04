using UnityEngine;

public class CapsuleItem : Item
{
    [SerializeField] private float _healthBoost;

    public override void Use ()
    {
        _player.BoostHealth(_healthBoost);

        base.Use();
    }
}
