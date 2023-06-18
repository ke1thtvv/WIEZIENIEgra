using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WIEZIENIEgra
{
    internal class Game
    {
        public Player MyPlayer;
        public TitleScene MyTitleScene; 
        public CellScene MyCellScene;
        public SquareScene MySquareScene;
        public FightScene MyFightScene;
        public CorridorScene MyCorridorScene;
        public CanteenScene MyCanteenScene;
        public Vent MyVent;
        public CreditsScene MyCreditsScene;

        public Game()
        {
            MyPlayer = new Player();
            MyVent = new Vent(MyPlayer);
            MyTitleScene = new TitleScene(this);
            MyCellScene = new CellScene(this);
            MySquareScene = new SquareScene(this);
            MyFightScene = new FightScene(this);
            MyCorridorScene = new CorridorScene(this);
            MyCanteenScene = new CanteenScene(this);
            MyCreditsScene = new CreditsScene(this);
        }

        public void Start()
        {
            MyTitleScene.Run();
        }
    }
}
