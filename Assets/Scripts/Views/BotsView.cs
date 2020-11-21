using System;
using Data.Bots;
using UnityEngine;

namespace Views
{
    public class BotsView : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private BotData _bot;

        private void Update()
        {
            // Move();
        }
        
        public void Initialize(BotData bot)
        {
            _bot = bot;
        }
        
        // Helpers.
        
        private void Move()
        {
            var currentPosition = prefab.transform.position;

            transform.position = Vector3.MoveTowards(currentPosition,
                _bot.NextOrLastDistance(currentPosition),
                _bot.Speed * Time.deltaTime);
        }
    }
}