using UnityEngine;

public class ParticleView : MonoBehaviour, IView
{
    public void OnMove(Vector3 newPosition)
    {
        transform.position = newPosition;
    }
}