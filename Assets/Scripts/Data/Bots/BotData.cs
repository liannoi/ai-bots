using Data.Trajectories;
using UnityEngine;

namespace Data.Bots
{
    [CreateAssetMenu]
    public class BotData : ScriptableObject
    {
        [SerializeField] private TrajectoryData trajectory;
        [SerializeField] private float speed;

        public float Speed => speed;

        public void Initialize(TrajectoryData trajectoryData)
        {
            trajectory = trajectoryData;
        }

        public Vector3 CurrentOrNext(Vector3 currentInScene)
        {
            return trajectory.CurrentOrNext(currentInScene);
        }
    }
}