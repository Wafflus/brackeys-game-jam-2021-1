using System.Collections.Generic;
using UnityEngine;

namespace Artistas
{
    [CreateAssetMenu(fileName = "New Explosive", menuName = "Artistas/Explosive/New Explosive")]
    public class ExplosiveSO : ScriptableObject
    {
        [Header("General Data")]
        public Sprite icon;
        public string title;
        [TextArea] public string description;

        [Header("Collision Layers")]
        public LayerMask explosiveCollisionLayer;
        public LayerMask propsCollisionLayer;
        public LayerMask destructibleCollisionLayer;

        [Header("Explosion Data")]
        [Min(0)] public float explosionRadius = 5f;
        [Range(0, 1)] public float instantExplosionRadius = .5f;
        [Min(0)] public float explosionForce = 10f;
        [Min(0)] public float timedExplosionTimer = 1f;
        [Min(0)] public float maxShakeForce = 2f;

        [Header("Explosion Visual Effects")]
        public List<GameObject> explosionEffects;

        [Header("Explosion Sound Effects")]
        public SoundListSO explosionSounds;

        [Header("Gizmos Data")]
        public GizmosData explosionGizmosData;
        public GizmosData instantExplosionGizmosData;

        public GameObject GetRandomExplosionEffect()
        {
            int randomIndex = Random.Range(0, explosionEffects.Count);

            return explosionEffects[randomIndex];
        }

        public void SetExplosionTimer(float value)
        {
            if (value < 0)
            {
                return;
            }

            timedExplosionTimer = value;
        }
    }
}
