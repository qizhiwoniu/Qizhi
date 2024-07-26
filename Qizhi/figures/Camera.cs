using Assimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qizhi.figures
{
    public class Camera
    {
        public bool IsOrthographic { get; private set; }
        public float OrthographicSize { get; private set; }
        public Vector3 Position { get; private set; }
        public Quaternion Rotation { get; private set; }

        public void SetOrthographic(bool isOrthographic)
        {
            IsOrthographic = isOrthographic;
        }

        public void SetOrthographicSize(float size)
        {
            OrthographicSize = size;
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
        }

        public void SetRotation(Quaternion rotation)
        {
            Rotation = rotation;
        }
    }
}
