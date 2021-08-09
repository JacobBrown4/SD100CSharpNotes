using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD
        // Create
        // Read
        // Update
        // Delete

        // Repository pattern = a "database" or list + CRUD methods

        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = _contentDirectory.Count > startingCount;
            return wasAdded;

            // return _contentDirectory.Count > startingCount;
        }

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
    }
}
