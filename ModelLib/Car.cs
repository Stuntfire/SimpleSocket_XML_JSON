using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    /// <summary>
    /// Link til opgaven: http://pele-easj.dk/2017e-tek/exercises/ch2-SocketXMLandJson.htm
    /// In the ModelLib create a 'Car'-class with the properties 'model, color, registration number'
    /// </summary>
    public class Car
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string regNumber;
        public string RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        public Car()
        {

        }

        public Car(string _model, string _color, string _regnumber)
        {
            this.Model = _model;
            this.Color = _color;
            this.RegNumber = _regnumber;
        }

        public override string ToString() => "Model: " + Model + "\tColor: " + Color + "\tRegistrationnr.: " + RegNumber;
    }
}
