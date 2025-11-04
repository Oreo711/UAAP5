using UnityEngine;

public class CubeItem : Item
{
    [SerializeField] private float _speedBoost;

    public override void Use ()
    {
        _player.BoostSpeed(_speedBoost);

        base.Use();
    }
}
