using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Data.Trajectories
{
    [CreateAssetMenu]
    public class TrajectoryData : ScriptableObject
    {
        [SerializeField] private List<Vector3> directions;

        public List<Vector3> Directions => directions;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            directions.ForEach(e => stringBuilder.Append($"({e.x}, {e.y}, {e.z})"));

            return stringBuilder.ToString();
        }
    }
}