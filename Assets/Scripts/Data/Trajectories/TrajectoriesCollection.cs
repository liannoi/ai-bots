using UnityEngine;

namespace Data.Trajectories
{
    public class TrajectoriesCollection : MonoBehaviour
    {
        [SerializeField] private TrajectoryData[] trajectories;

        public TrajectoryData SelectRandom()
        {
            return trajectories[Random.Range(0, trajectories.Length)];
        }
    }
}