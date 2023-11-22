using System;
using UniRx;
using UnityEngine.InputSystem;
using UnityEngine;

public class MovementBroadcaster : IDisposable
{
    private InputAction _input;
    private IMovable _movable;

    private CompositeDisposable _disposable = new CompositeDisposable();

    public MovementBroadcaster(InputAction input, IMovable movable)
    {
        _input = input;
        _movable = movable;

        _input.Enable();

        Observable.EveryUpdate().Subscribe(_ =>
        {
            var moveDirection = _input.ReadValue<Vector2>().normalized;

            _movable.Move(moveDirection);
        }).AddTo(_disposable);
    }

    public void Dispose()
    {
        _disposable.Clear();
    }
}