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
            CompletedMove();
        }

        public void Initialize(BotData bot)
        {
            _bot = bot;
        }

        // Helpers.

        private void CompletedMove()
        {
            var currentInScene = prefab.transform.position;
            var currentOrNext = _bot.CurrentOrNext(currentInScene);
            if (currentOrNext == currentInScene)
            {
                Destroy(gameObject);
                return;
            }

            transform.position = Vector3.MoveTowards(currentInScene, currentOrNext, _bot.Speed * Time.deltaTime);
        }
    }
}