using GeometryShape;

namespace TestProject
{
    public class TriangleTest
    {
        [Fact]
        public void RectangleCorrectPerimeter ()
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Assert.Equal(18, rectangle.Perimeter());
        }
    }
}
