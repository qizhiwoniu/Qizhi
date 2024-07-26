using SharpGL.SceneGraph;

namespace Qizhi.figures
{
    class Plane
    {



        public float ClassifyPoint(Vertex point) { return normal.ScalarProduct(point); }

        
        public Vertex normal = new Vertex(0, 0, 0);
        public float[] equation; // ax + by + cz + d = 0.

        



    }

   
}
