using UnityEngine;
using UnityEngine.LowLevel;


public abstract class Item : MonoBehaviour
{
    protected Player _player;

    private readonly Vector3 _offset = new Vector3(0, 1.5f, 0);
    private bool _isCollected;

    public void Initialize (Player player)
    {
        _player = player;
    }

    public void Collect ()
    {
        _isCollected = true;
    }

    private void Update ()
    {
        if (_isCollected)
        {
            transform.position = _player.transform.position + _offset;
            _player.HoldItem(this);

            if (Input.GetKeyDown(KeyCode.F))
            {
                Use();
            }
        }
    }

    public virtual void Use ()
    {
        Destroy(gameObject);
    }
}
