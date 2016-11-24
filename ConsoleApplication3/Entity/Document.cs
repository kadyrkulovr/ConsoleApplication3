using ConsoleApplication3.Entity;

namespace ConsoleApplication3.Entity
{
    internal class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        
        /// <summary>
        /// пользователь который создал документ
        /// </summary>
        public User User { get; set; }
    }
}