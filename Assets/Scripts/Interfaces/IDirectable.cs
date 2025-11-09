using UnityEngine;

public interface IDirectable
{
    Vector3 Direction {get;}

    // Update is called once per frame
    void ChangeDirection (Vector3 direction);
}
