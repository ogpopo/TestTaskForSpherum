using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CubeView : MonoBehaviour, IView
{
    private CharacterController _controller;

    private void OnEnable()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void OnMove(Vector3 newPosition)
    {
        //Debug.Log(newPosition);
        transform.position = newPosition;
    }
}