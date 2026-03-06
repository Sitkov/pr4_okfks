using GeometryShape;

namespace TestProject
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleFiled ()
        {
            Rectangle rectangle = new Rectangle(-5, 5);
            Assert.Equal(20, rectangle.Area());
        }
    }
}
