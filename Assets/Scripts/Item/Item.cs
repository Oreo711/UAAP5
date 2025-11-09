using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.LowLevel;


public abstract class Item : MonoBehaviour
{
    protected GameObject Collector;

    private readonly Vector3 _offset = new Vector3(0, 1.5f, 0);
    private bool _isCollected;

    public void Initialize (GameObject collector)
    {
        Collector = collector;
    }

    public void Collect ()
    {
        _isCollected = true;
    }

    private void Update ()
    {
        if (_isCollected)
        {
            transform.position = Collector.transform.position + _offset;
        }
    }

    public virtual void Use ()
    {
        Destroy(gameObject);
    }
}
