using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOI4EventGenerator
{
    public class Localisation
    {
        private int id;
        private int state;
        private string name;
        private string code;
        private string path;

        public Localisation(int id, int state, string name, bool liberation)
        {
            this.id = id;
            this.state = state;
            this.name = name;

            try
            {
                StreamReader localisationCapture = new StreamReader(@".\src\LocalisationCaptureTemplate.txt");
                code = localisationCapture.ReadToEnd() + "\n";
                if (liberation == true)
                {
                    StreamReader localisationLiberation = new StreamReader(@".\src\LocalisationLiberationTemplate.txt");
                    code = code + localisationLiberation.ReadToEnd();
                }
                code = code.Replace("[ID_EVENT]", this.id.ToString());
                code = code.Replace("[ID_EVENT_LIB]", (this.id + 1).ToString());
                code = code.Replace("[ID_STATE]", this.state.ToString());
                code = code.Replace("[NAME_EVENT]", this.name);
                code = code.Replace("[NAME_EVENT_CAP]", Utilities.ToCapName(this.name));
            }
            catch (FileNotFoundException)
            {
                code = "File code for localisation " + this.id + " not found.\n\n";
            }
        }
        public Localisation(int id, int state, string name, string code, string path)
        {
            this.id = id;
            this.state = state;
            this.name = name;
            this.code = code;
            this.path = path;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetState(int state)
        {
            this.state = state;
        }
        public int GetState()
        {
            return state;
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
        public void SetPath(string path)
        {
            this.path = path;
        }
        public string GetPath()
        {
            return path;
        }
    }
}
