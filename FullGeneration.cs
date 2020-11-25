using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOI4EventGenerator
{
    public class FullGeneration
    {
        private string eventCodeGeneration;
        private string onactionCodeGeneration;
        private string gfxCodeGeneration;
        private string localisationCodeGeneration;
        private string code;

        public FullGeneration(string eventCode, string onactionCode, string gfxCode, string localisationCode)
        {
            this.eventCodeGeneration = eventCode;
            this.onactionCodeGeneration = onactionCode;
            this.gfxCodeGeneration = gfxCode;
            this.localisationCodeGeneration = localisationCode;
            this.code = "#Event\n" + this.eventCodeGeneration + "\n#onaction\n" + this.onactionCodeGeneration + "\n#GFX\n" + this.gfxCodeGeneration + "\n#Localisation\n" + this.localisationCodeGeneration + "\n";
        }

        public void SetFullCode(string code)
        {
            this.code = code;
        }

        public string GetFullCode()
        {
            return code;
        }
    }
}
