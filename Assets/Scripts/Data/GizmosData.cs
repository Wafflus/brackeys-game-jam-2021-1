using System;
using UnityEngine;

namespace Artistas
{
    [Serializable]
    public class GizmosData
    {
        public Color color;
        public GizmosType type;

        public void Draw(Vector3 position, float radius)
        {
            Gizmos.color = color;

            switch (type)
            {
                case GizmosType.Cube:
                {
                    Gizmos.DrawCube(position, Vector3.one * radius);

                    break;
                }

                case GizmosType.WireCube:
                {
                    Gizmos.DrawWireCube(position, Vector3.one * radius);

                    break;
                }

                case GizmosType.Sphere:
                {
                    Gizmos.DrawSphere(position, radius);

                    break;
                }

                case GizmosType.WireSphere:
                {
                    Gizmos.DrawWireSphere(position, radius);

                    break;
                }
            }
        }

        public void Draw(Vector3 position, Vector3 size)
        {
            Gizmos.color = color;

            switch (type)
            {
                case GizmosType.Cube:
                {
                    Gizmos.DrawCube(position, size);

                    break;
                }

                case GizmosType.WireCube:
                {
                    Gizmos.DrawWireCube(position, size);

                    break;
                }
            }
        }
    }
}
