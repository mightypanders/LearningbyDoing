using GameControls;


namespace Game
{
    //introducing a change

    class GameObject
    {
        protected string _name;
        protected int _uID;

        public GameObject()
        {
            _name = null;
            _uID = 0;
        }
        public GameObject(Identifier ID, string name)
        {
            _name = name;
            _uID = ID.getuID();

        }
        public virtual bool move(int plusx, int plusy)
        {
            return false;
        }
        public string name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public int uID {
            get {
                return _uID;
            }
            set {
                _uID = value;
            }
        }
    }
    class PowerUp : GameObject
    {
        protected string _title;
        protected float _factor;
        protected int _amount;


        public PowerUp(Identifier ID, string name, string title, float factor, int amount) : base(ID, name)
        {
            //_uID = ID.getuID();
            //_name = name;
            _title = title;
            _factor = factor;
            _amount = amount;
            //_uID = ID.getuID();
        }
    }
    class Player : GameObject
    {

        protected short _playernumber;
        protected string _color;
        protected PowerUp[] _powerUps;
        protected short _lives;
        protected short _wins;
        protected short _losses;
        protected int _posX;
        protected int _posY;

        public Player(Identifier ID, string name, short playernumber, string color, PowerUp[] powerups, short lives, short wins, short losses, int posX, int posY) : base(ID, name)
        {
            //_uID = ID.getuID();
            //_name = name;
            _playernumber = playernumber;
            _color = color;
            _powerUps = powerups;
            _lives = lives;
            _wins = wins;
            _losses = losses;
            _posX = posX;
            _posY = posY;
        }



        public short playernumber {
            get {
                return _playernumber;
            }
            set {
                _playernumber = value;
            }
        }
        public override bool move(int plusx, int plusy)
        {

            return false;
        }

    }


}
