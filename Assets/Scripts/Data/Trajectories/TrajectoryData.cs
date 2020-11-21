using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Data.Trajectories
{
    [CreateAssetMenu]
    public class TrajectoryData : ScriptableObject
    {
        [SerializeField] private List<Vector3> distances;
        private int _index;

        private int Index
        {
            get
            {
                if (_index + 1 > distances.Count) _index = 0;

                return _index;
            }
            set => _index = value;
        }

        private Vector3 Last => distances.Last();
        private Vector3 Current => distances[Index];
        private Vector3 Next => distances[Index++];

        public Vector3 CurrentOrNext(Vector3 currentInScene)
        {
            return !IsCompleted(currentInScene) ? InPosition(currentInScene) ? Next : Current : currentInScene;
        }

        // Helpers.

        private bool IsCompleted(Vector3 currentInScene)
        {
            return Distance(Last, currentInScene);
        }

        private bool InPosition(Vector3 currentInScene)
        {
            return Distance(Current, currentInScene);
        }

        private bool Distance(Vector3 currentByIndex, Vector3 currentInScene)
        {
            return Vector3.Distance(currentByIndex, currentInScene) == 0;
        }
    }
}