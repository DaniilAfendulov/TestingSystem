using System;

namespace TestingSystem.Logic
{
    [Serializable]
    public class AuthorsBase : ListDataBase<Author>
    {
        public bool TryFind(string login, string password, out Author author)
        {
            foreach (var currentAuthor in _data)
            {
                if (currentAuthor.Equals(new Author(login, password)))
                {
                    author = currentAuthor;
                    return true;
                }
            }
            author = null;
            return false;
        }
    }
}