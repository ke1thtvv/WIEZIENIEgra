﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Scene
    {
        protected Game MyGame;

        public Scene(Game myGame)
        {
            MyGame = myGame;
        }

        virtual public void Run()
        {
        }
    }
}
