using FreindsHub.Data;
using FreindsHub.Models;

namespace FreindsHub.Repository
{
    public class FriendRepository : IFreindRepository
    {

        private readonly ApplicationDbContext _db;

        public FriendRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Friend> GetAllFreinds()
        {
          return  _db.Friends.ToList();
        }
  
        public Friend GetFriendById(int id)
        {
            return _db.Friends.Find(id);
        }

        public void AddFriend(Friend friend)
        {
          _db.Friends.Add(friend);
            _db.SaveChanges();
        }

      
        public void RemoveFriend(int id)
        {
            var friend = _db.Friends.Find(id);
            if (friend != null)
            {
                _db.Friends.Remove(friend);
                _db.SaveChanges();
            }

          
        }

        public void UpdateFriend(Friend friend)
        {
            _db.Friends.Update(friend);
            _db.SaveChanges();
        }
    }
}
