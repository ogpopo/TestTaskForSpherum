using System;
using System.Threading.Tasks;
using UniRx;
using UnityEngine.SceneManagement;

namespace Resourses.DistanceMeter
{
    public class SceneMeter : IDisposable
    {
        private bool switched = false;

        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        public SceneMeter(DistanceMeter distanceMeter)
        {
            Subscribe(distanceMeter);
        }

        private async void Subscribe(DistanceMeter distanceMeter)
        {
            await Task.Delay(100);

            distanceMeter.Distance.Subscribe(CheckDistance).AddTo(_disposable);
        }

        private void CheckDistance(float distance)
        {
            if (distance < 1 && switched == false)
            {
                switched = true;
                SceneManager.LoadScene(1);
            }
        }

        public void Dispose()
        {
            _disposable?.Dispose();
        }
    }
}