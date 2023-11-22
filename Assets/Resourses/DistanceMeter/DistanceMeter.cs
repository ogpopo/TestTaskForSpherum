using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class DistanceMeter : IModel, IDisposable
{
    private KeyValuePair<IMovable, IMovable> _targets;

    private CompositeDisposable _disposable = new CompositeDisposable();

    public ReactiveProperty<float> Distance { get; } = new ReactiveProperty<float>();

    public DistanceMeter(IMovable targetA, IMovable targetB)
    {
        Debug.Log("PresenterIsDispose");

        _targets = new KeyValuePair<IMovable, IMovable>(targetA, targetB);

        Observable.EveryUpdate().Subscribe(_ =>
        {
            if (_targets.Key == null || _targets.Value == null)
                return;

            Distance.Value = Vector3.Distance(_targets.Key.Position.Value, _targets.Value.Position.Value);
        }).AddTo(_disposable);
    }

    // private void Subscribe(KeyValuePair<IMovable, IMovable> targets)
    // {
    //     targets.Key.Position.Subscribe(OnPositionChanged).AddTo(_disposable);
    //     targets.Value.Position.Subscribe(OnPositionChanged).AddTo(_disposable);
    // }
    //
    // private void OnPositionChanged(Vector3 newPosition)
    // {
    // }

    public void Dispose()
    {
        _disposable.Clear();
    }
}