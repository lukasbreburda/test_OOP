using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_OOP
{
    class Seznam_aut
    {
        private string _color;
        private int _tachometr;
        private int _rok;
        private bool _stav;

        public string color
        {
         get { return _color; }
         set { _color = value; }
        }
        public int tachometr
        {
            get { return _tachometr; }
            set { _tachometr = value; }
        }
        public int rok
        {
            get { return _rok; }
            set { _rok = value; }
        }
        public bool stav
        {
            get { return _stav; }
            set { _stav = value; }
        }
    }
}
