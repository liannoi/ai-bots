using System.Linq;
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
            var count = botsCollection.Bots.Count;

            for (var i = 0; i < count; ++i)
            {
                Instantiate(prefab, viewParent).GetComponent<BotsView>().Initialize(botsCollection.Bots[i]);
                prefab.transform.position = new Vector3(-20.0F, 1.03F, -20.0F + i * 4.5F);
            }
        }
    }
}