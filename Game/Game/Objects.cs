using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameControls;


namespace Game
{
    //introducing a change

    class Objects
    {
        protected string _name;
        protected int _uID;

        public Objects()
        {
            _name = null;
            _uID = 0;
        }
        public Objects(Identifier ID, string name)
        {
            _name = name;
            _uID = ID.getuID();

        }
        public virtual bool move(int plusx, int plusy)
        {
            return false;
        }
    }
    class PowerUps : Objects
    {
        protected string _title;
        protected float _factor;
        protected int _amount;


        public PowerUps(Identifier ID, string name, string title, float factor, int amount)
        {
            _uID = ID.getuID();
            _name = name;
            _title = title;
            _factor = factor;
            _amount = amount;
            _uID = ID.getuID();
        }
    }
    class Player : Objects
    {

        protected short _playernumber;
        protected string _color;
        protected PowerUps[] _powerUps;
        protected short _lives;
        protected short _wins;
        protected short _losses;
        protected int _posX;
        protected int _posY;

        public Player(Identifier ID, string name, short playernumber, string color, PowerUps[] powerups, short lives, short wins, short losses, int posX, int posY)
        {
            _uID = ID.getuID();
            _name = name;
            _playernumber = playernumber;
            _color = color;
            _powerUps = powerups;
            _lives = lives;
            _wins = wins;
            _losses = losses;
            _posX = posX;
            _posY = posY;
        }

        public short playernumber
        {
            get
            {
                return _playernumber;
            }
            set
            {
                _playernumber = value;
            }
        }
        public override bool move(int plusx, int plusy)
        {

            return false;
        }

    }


}
