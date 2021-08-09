using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType GenreType { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, bool familyFriendly, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            IsFamilyFriendly = familyFriendly;
            GenreType = genre;
        }

        // Refactor the class so that IsFamilyFriendly always gives the right answer
    }
}

public enum MaturityRating { G, PG, R, PG13, NC17, TVMA, TVG, TVY }
public enum GenreType { SciFi = 1, Comedy, Horror, RomCom, Documentary, Western, Action }
