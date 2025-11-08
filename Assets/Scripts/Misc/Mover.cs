using UnityEngine;

public class Mover
{
    public void MoveToTargetPoint (GameObject body, Vector3 target, float speed)
    {
        body.transform.position = Vector3.MoveTowards(body.transform.position, target, speed * Time.deltaTime);
    }

    public void MoveInDirection (GameObject body, Vector3 direction, float speed)
    {
        body.transform.Translate(direction * (speed * Time.deltaTime));
    }

    public void LookInDirection (GameObject body, Vector3 direction, float speed = 1000f)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction.normalized);
        float step = speed * Time.deltaTime;

        body.transform.rotation = Quaternion.RotateTowards(body.transform.rotation, lookRotation, step);
    }
}
