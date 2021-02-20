using UnityEngine;

namespace Artistas
{
    public class Explosive : MonoBehaviour
    {
        [SerializeField] private ExplosiveSO explosiveSO;

        private Rigidbody rb;

        private bool timedExplosion = false;
        private float explosionTimer;

        private void Awake()
        {
            explosionTimer = explosiveSO.timedExplosionTimer;
            rb = gameObject.GetComponent<Rigidbody>();
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

        private void Start()
        {
            SetTimedExplosion();
        }

        private void FixedUpdate()
        {
            if (!timedExplosion)
            {
                return;
            }

            AddRandomShake();
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

        public void AddRandomShake()
        {
            rb.AddForce(Random.insideUnitSphere.normalized * explosiveSO.maxShakeForce);
        }

        public void Explode()
        {
            gameObject.layer = LayerMask.NameToLayer("Props");

            ExplodeNearbyExplosives();
            DamageDestructibles();
            InstantiateExplosionEffect();
            PlayExplosionSound();

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

        private void DamageDestructibles()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosiveSO.explosionRadius, explosiveSO.destructibleCollisionLayer);

            foreach (Collider collider in colliders)
            {
                Destructible destructible = collider.gameObject.GetComponent<Destructible>();

                if (destructible == null)
                {
                    continue;
                }

                // This will have to be tested properly.
                float distanceDamageModifier = 1f - Mathf.Clamp(Vector3.Distance(transform.position, collider.gameObject.transform.position) / explosiveSO.explosionRadius, 0f, 1f);
                float damage = explosiveSO.explosionForce * distanceDamageModifier;

                destructible.Damage(damage);
            }

            ApplyExplosionForces();
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

        private void InstantiateExplosionEffect()
        {
            GameObject explosionEffect = Instantiate(explosiveSO.GetRandomExplosionEffect(), transform.position, Quaternion.identity);

            Destroy(explosionEffect, 5f);
        }

        private void PlayExplosionSound()
        {
            AudioSource.PlayClipAtPoint(explosiveSO.explosionSounds.GetRandomSound(), transform.position, 1f);
        }
    }
}