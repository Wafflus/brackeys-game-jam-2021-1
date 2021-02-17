using UnityEngine;

namespace Artistas
{
    public class Explosive : MonoBehaviour
    {
        [SerializeField] private ExplosiveSO explosiveSO;

        private bool timedExplosion = false;
        private float explosionTimer;

        private void Awake()
        {
            explosionTimer = explosiveSO.timedExplosionTimer;
        }

        private void OnDrawGizmos()
        {
            explosiveSO.explosionGizmosData.Draw(transform.position, explosiveSO.explosionRadius);
            explosiveSO.instantExplosionGizmosData.Draw(transform.position, explosiveSO.explosionRadius * explosiveSO.instantExplosionRadius);
        }

        private void Update()
        {
            if (!timedExplosion)
            {
                return;
            }

            Tick();
        }

        private void Tick()
        {
            explosionTimer -= Time.deltaTime;

            if (explosionTimer <= 0)
            {
                timedExplosion = false;

                Explode();
            }
        }

        public void Explode()
        {
            gameObject.layer = LayerMask.NameToLayer("Props");

            GameObject explosionEffect = Instantiate(explosiveSO.GetRandomExplosionEffect(), transform.position, Quaternion.identity);

            Destroy(explosionEffect, 5f);

            ExplodeNearbyExplosives();

            ApplyExplosionForces();

            Destroy(gameObject);
        }

        public void SetTimedExplosion()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");

            timedExplosion = true;
        }

        private void ExplodeNearbyExplosives()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosiveSO.explosionRadius, explosiveSO.explosiveCollisionLayer);
            
            foreach (Collider collider in colliders)
            {
                Explosive explosive = collider.gameObject.GetComponent<Explosive>();

                float distance = Vector3.Distance(transform.position, collider.gameObject.transform.position);

                if (distance > explosiveSO.explosionRadius * explosiveSO.instantExplosionRadius)
                {
                    explosive.SetTimedExplosion();

                    continue;
                }

                explosive.Explode();
            }
        }

        private void ApplyExplosionForces()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosiveSO.explosionRadius, explosiveSO.propsCollisionLayer);

            foreach (Collider collider in colliders)
            {
                Rigidbody colliderRigidbody = collider.attachedRigidbody;

                if (colliderRigidbody == null)
                {
                    continue;
                }

                colliderRigidbody.AddExplosionForce(explosiveSO.explosionForce, transform.position, explosiveSO.explosionRadius);
            }
        }
    }
}