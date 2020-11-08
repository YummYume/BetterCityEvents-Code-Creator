using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOI4EventGenerator
{
    public class Event
    {
        private int id;
        private string name;
        private string code;
        private string path;

        public Event(int id, string name, bool liberation)
        {
            this.id = id;
            this.name = name;
            try
            {
                StreamReader eventCapture = new StreamReader(@".\src\EventCaptureTemplate.txt");
                code = eventCapture.ReadToEnd() + "\n\n";
                if (liberation == true)
                {
                    StreamReader eventLiberation = new StreamReader(@".\src\EventLiberationTemplate.txt");
                    code = code + "\n\n" + eventLiberation.ReadToEnd() + "\n\n";
                }
                code = code.Replace("[ID_EVENT]", this.id.ToString());
                code = code.Replace("[ID_EVENT_LIB]", (this.id + 1).ToString());
                code = code.Replace("[NAME_EVENT]", this.name);
                code = code.Replace("[NAME_EVENT_CAP]", Utilities.ToCapName(this.name));
            }
            catch (FileNotFoundException)
            {
                code = "File code for event " + this.id + " not found.\n\n";
            }
        }
        public Event(int id, string name, string code, string path)
        {
            this.id = id;
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

        public bool EditEventNameCode(Event currentEvent, string oldName, string newName)
        {
            if (currentEvent.GetCode().Contains(oldName) == true)
            {
                currentEvent.SetCode(currentEvent.GetCode().Replace(oldName, newName));
                currentEvent.SetCode(currentEvent.GetCode().Replace(Utilities.ToCapName(oldName), Utilities.ToCapName(newName)));
                return true;
            }
            return false;
        }

        public bool EditEventIDCode(Event currentEvent, int oldID, int newID)
        {
            if (currentEvent.GetCode().Contains(oldID.ToString()) == true)
            {
                currentEvent.SetCode(currentEvent.GetCode().Replace(oldID.ToString(), newID.ToString()));
                return true;
            }
            return false;
        }
    }
}
