using FreindsHub.Models;
using FreindsHub.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FreindsHub.Controllers
{
    public class FriendsController : Controller
    {
        private readonly IFreindRepository _repository;

        public FriendsController(IFreindRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var friends = _repository.GetAllFreinds();
            return View(friends);
        }

        public IActionResult Details(int id)
        {
        
            var friends = _repository.GetFriendById(id);
            return View(friends);
        }


        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Friend friend)
        {
        
                _repository.AddFriend(friend);
                return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var freinds = _repository.GetFriendById(id);
            return View(freinds);
        }

        [HttpPost]
        public IActionResult Edit(Friend friend)
        {
            _repository.UpdateFriend(friend);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var freinds = _repository.GetFriendById(id);
            return View(freinds);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.RemoveFriend(id);
            return RedirectToAction("Index");
        }
    }
}
