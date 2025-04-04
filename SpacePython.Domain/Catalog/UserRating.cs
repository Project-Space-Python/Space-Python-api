using System;

namespace SpacePython.Domain.Catalog
{
    public class UserRating
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        public UserRating(int stars, string userName, string review)
        {
            if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5.");
            }

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null.");
            }

            Stars = stars;
            UserName = userName;
            Review = review;
        }
    }
}
