using System.Collections;

namespace CM_CSharp_Course.Enums;

public class Enums
{

    public void EnumsMainMethod()
    {
        List<int> intList = new List<int>();
        PlayerStats playerStats = new PlayerStats();
        
        foreach (Stat stat in playerStats)
        {
            Console.WriteLine(stat);
        }
    }
    public class Stat
    {
        public string name;
        public int value;

        public override string ToString()
        {
            return $"{name}: {value}";
        }
    }
    public class PlayerStats : IEnumerable<Stat>
    {
        public Stat dexterity = new Stat { name = "dexterity", value = 0 };
        public Stat intelligence = new Stat { name = "intelligence", value = 0 };
        public Stat strength = new Stat { name = "strength", value = 0 };
        public Stat wisdom = new Stat { name = "wisdom", value = 0 };

        /*public IEnumerator<Stat> GetEnumerator()
        {
            yield return dexterity;
            yield return intelligence;
            yield return strength;
            yield return wisdom;
        }*/
        public IEnumerator<Stat> GetEnumerator()
        {
            return new PlayerStatEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public class PlayerStatEnumerator : IEnumerator<Stat>
        {
            private PlayerStats _playerStats;
            private int _index;

            public PlayerStatEnumerator(PlayerStats playerStats)
            {
                this._playerStats = playerStats;
                _index = -1;
            }
            
            object? IEnumerator.Current => Current;

            public Stat Current
            {
                get
                {
                    switch (_index)
                    {
                        default:
                        case 0: return _playerStats.dexterity;
                        case 1: return _playerStats.intelligence;
                        case 2: return _playerStats.strength;
                        case 3: return _playerStats.wisdom;
                    }
                }
            }
            
            public bool MoveNext()
            {
                _index++;
                if(_index > 3)
                {
                    _index = -1;
                }
                return _index != -1;
            }

            public void Reset()
            {
                _index = -1;
            }

            public void Dispose()
            {
            }
        }
    }
}