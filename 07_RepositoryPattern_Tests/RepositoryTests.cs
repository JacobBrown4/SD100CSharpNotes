using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void AddContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent content = new StreamingContent();
            content.Title = "I Am Here.... NOW";
            // Act
            bool addResult = repo.AddContentToDirectory(content);
            // Assert
            Assert.IsTrue(addResult);
        }
    }
}
