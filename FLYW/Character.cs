using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseFlyweight.Flyweight
{
   public class Character
    {
        protected char symbol;
        protected string code;
        public void Display(TextBox _text)
        {
            _text.Text += code;
        }
    }
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();
        public Character this[char key]
        {
            get
            {
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    string name = this.GetType().Namespace + "." + "Character" + key.ToString();
                    character = (Character)Activator.CreateInstance(Type.GetType(name));
                }
                return character;
            }
        }
    }
    public class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = 'A';
            code = ".-";
        }
    }
    public class CharacterB : Character
    {
        public CharacterB()
        {
            symbol = 'B';
            code = "-…";
        }
    }
    public class CharacterC : Character
    {
        public CharacterC()
        {
            symbol = 'C';
            code = "-.-.";
        }
    }
    public class CharacterD : Character
    {
        public CharacterD()
        {
            symbol = 'D';
            code = "-..";
        }
    }
    public class CharacterE : Character
    {
        public CharacterE()
        {
            symbol = 'E';
            code = ".";
        }
    }
    public class CharacterF : Character
    {
        public CharacterF()
        {
            symbol = 'F';
            code = "..-.";
        }
    }
    public class CharacterG : Character
    {
        public CharacterG()
        {
            symbol = 'G';
            code = "--.";
        }
    }

    public class CharacterH : Character
    {
        public CharacterH()
        {
            symbol = 'H';
            code = "….";
        }
    }

    public class CharacterI : Character
    {
        public CharacterI()
        {
            symbol = 'I';
            code = "..";
        }
    }
    public class CharacterJ : Character
    {
        public CharacterJ()
        {
            symbol = 'j';
            code = ".---";
        }
    }

    public class CharacterK : Character
    {
        public CharacterK()
        {
            symbol = 'K';
            code = "-.-";
        }
    }
    public class CharacterL : Character
    {
        public CharacterL()
        {
            symbol = 'L';
            code = ".-..";
        }
    }
    public class CharacterM : Character
    {
        public CharacterM()
        {
            symbol = 'M';
            code = "--";
        }
    }
    public class CharacterN : Character
    {
        public CharacterN()
        {
            symbol = 'N';
            code = "-.";
        }
    }
    public class CharacterO : Character
    {
        public CharacterO()
        {
            symbol = 'O';
            code = "---";
        }
    }
    public class CharacterP : Character
    {
        public CharacterP()
        {
            symbol = 'P';
            code = ".--.";
        }
    }
    public class CharacterQ : Character
    {
        public CharacterQ()
        {
            symbol = 'Q';
            code = "--.-";
        }
    }
    public class CharacterR : Character
    {
        public CharacterR()
        {
            symbol = 'R';
            code = ".-.";
        }
    }
    public class CharacterS : Character
    {
        public CharacterS()
        {
            symbol = 'S';
            code = "…";
        }
    }
    public class CharacterT : Character
    {
        public CharacterT()
        {
            symbol = 'T';
            code = "-";
        }
    }
    public class CharacterU : Character
    {
        public CharacterU()
        {
            symbol = 'U';
            code = "..-";
        }
    }
    public class CharacterV : Character
    {
        public CharacterV()
        {
            symbol = 'V';
            code = "…-";
        }
    }
    public class CharacterW : Character
    {
        public CharacterW()
        {
            symbol = 'W';
            code = ".--";
        }
    }
    public class CharacterX : Character
    {
        public CharacterX()
        {
            symbol = 'X';
            code = "-..-";
        }
    }
    public class CharacterY : Character
    {
        public CharacterY()
        {
            symbol = 'Y';
            code = "-.--";
        }
    }
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol = 'Z';
            code = "--..";
        }
    }
    public class Character1 : Character
    {
        public Character1()
        {
            symbol = '1';
            code = ".----";
        }
    }
    public class Character2 : Character
    {
        public Character2()
        {
            symbol = '2';
            code = "..---";
        }
    }

    public class Character3 : Character
    {
        public Character3()
        {
            symbol = '3';
            code = "…--";
        }
    }

    public class Character4 : Character
    {
        public Character4()
        {
            symbol = '4';
            code = "….-";
        }
    }
    public class Character5 : Character
    {
        public Character5()
        {
            symbol = '5';
            code = "…..";
        }
    }

    public class Character6 : Character
    {
        public Character6()
        {
            symbol = '6';
            code = "-….";
        }
    }

    public class Character7 : Character
    {
        public Character7()
        {
            symbol = '7';
            code = "--…";
        }
    }
    public class Character8 : Character
    {
        public Character8()
        {
            symbol = '8';
            code = "---..";
        }
    }

    public class Character9 : Character
    {
        public Character9()
        {
            symbol = '9';
            code = "----.";
        }
    }
    public class Character0 : Character
    {
        public Character0()
        {
            symbol = '0';
            code = "-----";
        }
    }
}
