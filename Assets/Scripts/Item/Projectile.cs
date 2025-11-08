using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float   _speed    = 10f;
    private float   _lifespan = 2f;

    private Mover   _mover = new Mover();

    public Vector3 Direction {get; private set;}

    public void Launch (Vector3 direction)
    {
        Direction = direction;
    }

    private void Update ()
    {
        _lifespan -= Time.deltaTime;

        if (_lifespan <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate ()
    {
        _mover.MoveInDirection(gameObject, Direction, _speed);
    }
}
