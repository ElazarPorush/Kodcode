using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Domain
{
    internal class Piller
    {
        private float _hight;
        public float Hight { get { return _hight; } set { _hight = value; } }
        private float _width;
        public float Width { get { return _width; } set { _width = value; } }
        private string _area;
        public string Area { get { return _area; } set { _area = value; } }
        public string Domain { 
            get {
                if (_area == "רשות הרבים") {
                    if (_hight < 3 || _hight >= 9 && _hight < 10)
                    {
                        return "דין רשות הרבים";
                    }
                    else if (_hight < 9 && _hight >= 3)
                    {
                        if (_width >= 4)
                        {
                            return "דין כרמלית";
                        }
                        return "דין מקום פטור";
                    }
                    else if (_hight >= 10) {
                        if (_width >= 4)
                        {
                            return "דין רשות היחיד";
                        }
                        return "דין מקום פטור";
                    }
                }
                else if (_area == "כרמלית")
                {
                    if (_hight < 10 && _width >= 4)
                    {
                        return "דין כרמלית";
                    }
                    else if (_hight >= 10)
                    {
                        if (_width >= 4)
                        {
                            return "דין רשות היחיד";
                        }
                        return "לטור: דינו ככרמלית, ולרשי: דינו מקום פטור";
                    }
                }
                else if (_area == "רשות היחיד")
                {
                    return "דין רשות היחיד";
                }
                return "Eror!";
            }
        }
    }
}
