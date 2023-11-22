using System;
using UniRx;
using UnityEngine;

public class CubePresenter : PresenterBase<Cube, CubeView>, IDisposable
{
    private readonly CompositeDisposable _disposable = new CompositeDisposable();

    public CubePresenter(Cube model, CubeView view) : base(model, view)
    {
        Model.Position.Subscribe(view.OnMove).AddTo(_disposable);
    }

    public void Dispose()
    {
        _disposable.Clear();
    }
}