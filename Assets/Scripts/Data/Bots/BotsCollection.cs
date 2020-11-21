using System.Collections.Generic;
using Data.Trajectories;
using UnityEngine;

namespace Data.Bots
{
    public class BotsCollection : MonoBehaviour
    {
        [SerializeField] private List<BotData> bots;
        [SerializeField] private TrajectoriesCollection trajectories;

        public IList<BotData> Bots => bots;

        private void Start()
        {
            foreach (var bot in bots) bot.Trajectory = trajectories.SelectRandom();
        }
    }
}