using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concate
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            return true;
        }
    }
}
