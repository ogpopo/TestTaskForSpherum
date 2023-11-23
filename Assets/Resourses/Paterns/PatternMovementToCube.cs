using System;
using System.Collections.Generic;
using Resourses.Abstarct;
using Zenject;

namespace Resourses.Paterns
{
    public class PatternMovementToCube : IMovablePattern
    {
        private KeyValuePair<IMovable, IMovable> _targets;

        public PatternMovementToCube([Inject(Id = InjectionIDs.RedCubeId)] IMovable targetA,
            [Inject(Id = InjectionIDs.GreenCubeId)]
            IMovable targetB)
        {
            _targets = new KeyValuePair<IMovable, IMovable>(targetA, targetB);
        }

        public IMovable GetNextTarget(IMovable pastTarget)
        {
            if (pastTarget == null)
                throw new NullReferenceException();

            return _targets.Key == pastTarget ? _targets.Value : _targets.Key;
        }
    }
}