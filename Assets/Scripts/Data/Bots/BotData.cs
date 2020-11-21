using System.Linq;
using Data.Trajectories;
using UnityEngine;

namespace Data.Bots
{
    [CreateAssetMenu]
    public class BotData : ScriptableObject
    {
        [SerializeField] private TrajectoryData trajectory;
        [SerializeField] private float speed;
        private int _index;

        public TrajectoryData Trajectory
        {
            get => trajectory;
            set => trajectory = value;
        }

        public float Speed => speed;

        private Vector3 LastDistance => trajectory.Directions.Last();

        public Vector3 NextOrLastDistance(Vector3 currentDistance)
        {
            return Vector3.Distance(LastDistance, currentDistance) == 0.0F ? LastDistance : NextDistance();
        }

        // Helpers.

        private Vector3 NextDistance()
        {
            if (_index + 1 > trajectory.Directions.Count) _index = 0;

            return trajectory.Directions[_index++];
        }
    }
}