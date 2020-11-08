using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOI4EventGenerator
{
    public class Onaction
    {
        private int id; //id event
        private int state; //id state
        private string name;
        private string code;
        private string codeStateList;
        private string path;

        public Onaction(int id, int state, string name, bool capital)
        {
            this.id = id;
            this.state = state;
            this.name = name;

            try
            {
                if (capital == true)
                {
                    StreamReader onactionCapital = new StreamReader(@".\src\onactionCapitalTemplate.txt");
                    code = onactionCapital.ReadToEnd() + "\n";
                }
                else
                {
                    StreamReader onactionNonCapital = new StreamReader(@".\src\onactionNonCapitalTemplate.txt");
                    code = onactionNonCapital.ReadToEnd() + "\n";
                }
                code = code.Replace("[ID_EVENT]", this.id.ToString());
                code = code.Replace("[ID_EVENT_LIB]", (this.id + 1).ToString());
                code = code.Replace("[ID_STATE]", this.state.ToString());
                code = code.Replace("[NAME_CITY]", this.name);
                code = code.Replace("[NAME_CITY_CAP]", Utilities.ToCapName(this.name));

                StreamReader stateList = new StreamReader(@".\src\onactionStateListTemplate.txt");
                codeStateList = stateList.ReadToEnd() + "\n";
                codeStateList = codeStateList.Replace("[ID_STATE]", this.state.ToString());
                codeStateList = codeStateList.Replace("[NAME_CITY_CAP]", Utilities.ToCapName(this.name));
            }
            catch (FileNotFoundException)
            {
                code = "File code for onaction " + this.id + " not found.\n\n";
            }
        }
        public Onaction(int id, int state, string name, string code, string codeStateList, string path)
        {
            this.id = id;
            this.state = state;
            this.name = name;
            this.code = code;
            this.codeStateList = codeStateList;
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
        public void SetCodeStateList(string stateList)
        {
            this.codeStateList = stateList;
        }
        public string GetCodeStateList()
        {
            return codeStateList;
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
