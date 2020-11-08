using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOI4EventGenerator
{
    public class GFX
    {
        private string name;
        private string code;
        private bool capture;

        public GFX(string name, bool capture)
        {
            this.name = name;
            this.capture = capture;

            try
            {
                StreamReader GFXCode = new StreamReader(@".\src\GFXTemplate.txt");
                code = GFXCode.ReadToEnd() + "\n\n";
                if (capture == true)
                {
                    code = code.Replace("[STATUS_CITY]", "capture");
                }
                else
                {
                    code = code.Replace("[STATUS_CITY]", "liberation");
                }
                code = code.Replace("[NAME_GFX]", name);
            }
            catch (FileNotFoundException)
            {
                code = "File code for GFX " + Utilities.ToCapName(name) + " not found.\n\n";
            }
        }

        public void SetName(string name)
        {
            name.ToLower();
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCode(string code)
        {
            this.code = code;
        }
        public string GetCode()
        {
            return code;
        }
        public void SetCapture(bool capture)
        {
            this.capture = capture;
        }
        public bool GetCapture()
        {
            return capture;
        }
    }
}
