using System.Collections.Generic;
using Data.Trajectories;
using UnityEngine;

namespace Data.Bots
{
    public class BotsCollection : MonoBehaviour
    {
        [SerializeField] private List<BotData> bots;
        [SerializeField] private TrajectoriesCollection trajectories;

        public float Count => bots.Count;

        private void Start()
        {
            foreach (var bot in bots) bot.Initialize(trajectories.SelectRandom());
        }

        public BotData GetByIndex(int index)
        {
            return bots[index];
        }
    }
}