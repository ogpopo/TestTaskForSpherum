using UnityEngine;

namespace Resourses.Abstarct
{
    public interface IMovablePattern
    {
        public IMovable GetNextTarget(IMovable pastTarget);
    }
}