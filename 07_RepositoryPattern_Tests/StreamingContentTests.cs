using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            StreamingContent movie = new StreamingContent();
            Console.WriteLine($"{movie.Title} is a {movie.GenreType} movie about {movie.Description} rated {movie.MaturityRating}");
        }

        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // AAA Pattern
            
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.Title = "Double Down";

            // Assert
            string expected = "DOUBLE DOWN";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMaturityRating_ShouldGetCorrectFamilyFriendly()
        {

        }
    }
}
