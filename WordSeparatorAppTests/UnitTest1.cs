using FluentAssertions; 
using WordSeparatorApp;

namespace WordSeparatorAppTests
{ 
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            string s = "abc xyz def uvw ghi";

            //Act
            string[] result = Program.CompoundStrings(s);

            //Assert
            string[] expected = { "abc", "def", "ghi", "uvw", "xyz" };
            result.Should().ContainInOrder(expected);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            string s = "abc xyz dec uvw ghi";

            //Act
            string[] result = Program.CompoundStrings(s);

            //Assert
            string[] expected = { "abc", "dec", "ghi", "uvw", "xyz" };
            result.Should().ContainInOrder(expected);
        }

        [Test]
        public void Test3()
        {
            //Arrange
            string s = "abc wxyz dec tuvw ghic";

            //Act
            string[] result = Program.CompoundStrings(s);

            //Assert
            string[] expected = { "abc", "dec", "ghic", "tuvw", "wxyz" };
            result.Should().ContainInOrder(expected);
        }
    }
}