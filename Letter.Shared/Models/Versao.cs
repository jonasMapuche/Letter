using System;
using System.Collections.Generic;
using System.Text;

namespace Letter.Models
{
    public class Versao
    {
        public String tag_name { get; set; }
        public String target_commitish { get; set; }
        public String name { get; set; }
        public String body { get; set; }
        public Boolean draft { get; set; }
        public Boolean prerelease { get; set; }
        public Boolean generate_release_notes { get; set; }

        public Versao() { }

        public Versao(String versao)
        {
            this.tag_name = versao;
            this.target_commitish = "main";
            this.name = versao;
            this.body = "New version!";
            this.draft = false;
            this.prerelease = false;
            this.generate_release_notes = false;
        }
    }
}
