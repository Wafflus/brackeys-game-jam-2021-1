using UnityEngine;

namespace Artistas
{
    [CreateAssetMenu(fileName = "New Explosive", menuName = "Artistas/Explosive/New Explosive")]
    public class ExplosiveSO : ScriptableObject
    {
        public Sprite icon;
        public string title;
        [TextArea] public string description;

        public LayerMask explosiveCollisionLayer;
        public LayerMask propsCollisionLayer;

        [Min(0)] public float explosionRadius = 5f;
        [Range(0, 1)] public float instantExplosionRadius = .5f;

        [Min(0)] public float explosionForce = 10f;

        [Min(0)] public float timedExplosionTimer = 1f;

        public GizmosData explosionGizmosData;
        public GizmosData instantExplosionGizmosData;
    }
}
