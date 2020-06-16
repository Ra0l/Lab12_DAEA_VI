﻿namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentCode", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentFechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "studentFechaModificacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "studentFechaModificacion");
            DropColumn("dbo.Students", "studentFechaCreacion");
            DropColumn("dbo.Students", "studentLastName");
            DropColumn("dbo.Students", "studentCode");
        }
    }
}
