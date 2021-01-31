using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concate
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine(gamer.FirstName+" eklendi ");
            }
            else
            {
                Console.WriteLine(gamer.FirstName+" eklenemedi");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" silindi ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" güncellendi ");
        }
    }
}
