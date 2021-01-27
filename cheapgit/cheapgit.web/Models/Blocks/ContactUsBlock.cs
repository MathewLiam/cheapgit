namespace cheapgit.web.Models.Blocks
{
    using Piranha.Data.EF.SQLServer.Migrations;
    using Piranha.Extend;
    using Piranha.Extend.Fields;
    using Piranha.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [BlockType(Name = "Contact Us", Category = "Content",
    Icon = "fas fa-phone", Component = "contact-block")]
    public class ContactUsBlock : Block
    {
        public TextField Content { get; set; }
        public StringField Email { get; set; }
        public StringField PhoneNumber { get; set; }
    }
}
