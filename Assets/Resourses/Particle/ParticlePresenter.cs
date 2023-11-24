using System;
using Resourses.Abstarct;
using UniRx;

namespace Resourses.Particle
{
    public class ParticlePresenter : PresenterBase<Particle, ParticleView>, IDisposable
    {
        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        public ParticlePresenter(Particle model, ParticleView view) : base(model, view)
        {
            Model.Position.Subscribe(view.OnMove).AddTo(_disposable);
        }

        public void Dispose()
        {
            _disposable.Clear();
        }
    }
}