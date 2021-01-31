using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampagnService
    {
        void Add(Campagn campaign);
        void Update(Campagn campaign);
        void Delete(Campagn campaign);
    }
}
