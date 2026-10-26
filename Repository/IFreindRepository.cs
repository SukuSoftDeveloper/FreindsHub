using FreindsHub.Models;

namespace FreindsHub.Repository
{
    public interface IFreindRepository
    {
        public List<Friend> GetAllFreinds();

        public Friend GetFriendById(int id);

        public void AddFriend(Friend friend);

        public void RemoveFriend(int id);

        public void UpdateFriend(Friend friend);
    }
}
