using System;
using Resourses.Abstarct;
using Resourses.DistanceMeter;
using UniRx;

namespace Resourses.DistanceMeter
{
    public class DistanceMeterPresenter : PresenterBase<DistanceMeter, DistanceMeterUIView>, IDisposable
    {
        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        public DistanceMeterPresenter(DistanceMeter model, DistanceMeterUIView view) : base(model, view)
        {
            Model.Distance.Subscribe(View.OnChangedDistance);
        }

        public void Dispose()
        {
            _disposable.Clear();
        }
    }
}