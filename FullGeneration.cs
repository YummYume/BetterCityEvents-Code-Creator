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
        private Event eventGeneration;
        private Onaction onactionGeneration;
        private GFX gfxGeneration;
        private Localisation localisationGeneration;
        private string code;

        public FullGeneration(Event eventObj, Onaction onaction, GFX gfx, Localisation localisation)
        {
            this.eventGeneration = eventObj;
            this.onactionGeneration = onaction;
            this.gfxGeneration = gfx;
            this.localisationGeneration = localisation;
            this.code = "#Event\n" + this.eventGeneration.GetCode() + "\n#onaction\n" + this.onactionGeneration.GetCode() + "\n#GFX\n" + this.gfxGeneration.GetCode() + "\n#Localisation\n" + this.localisationGeneration.GetCode() + "\n";
        }

        public void SetCode(string code)
        {
            this.code = code;
        }

        public string GetCode()
        {
            return code;
        }
    }
}
