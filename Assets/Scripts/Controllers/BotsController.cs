using Data.Bots;
using JetBrains.Annotations;
using UnityEngine;
using Views;

namespace Controllers
{
    public class BotsController : MonoBehaviour
    {
        [SerializeField] private BotsCollection botsCollection;
        [SerializeField] private GameObject prefab;
        [SerializeField] [CanBeNull] private Transform viewParent;

        private void Start()
        {
            var count = botsCollection.Count;

            for (var i = 0; i < count; ++i)
            {
                Instantiate(prefab, viewParent).GetComponent<BotsView>().Initialize(botsCollection.GetByIndex(i));
                prefab.transform.position = new Vector3(-55, 1, -30 + i * 6);
            }
        }
    }
}