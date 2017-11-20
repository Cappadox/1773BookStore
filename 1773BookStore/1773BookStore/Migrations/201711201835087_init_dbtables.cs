namespace _1773BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_dbtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(maxLength: 128),
                        Type = c.String(),
                        City = c.String(),
                        District = c.String(),
                        Street = c.String(),
                        Zipcode = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.Int(nullable: false),
                        Title = c.String(),
                        PublishYear = c.DateTime(),
                        Edition = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Page = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Single(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Book_Author_Mapping",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BookTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.BookTypes", t => t.BookTypeId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.BookTypeId);
            
            CreateTable(
                "dbo.BookTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Book_BookType_Mapping",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BookTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.BookTypes", t => t.BookTypeId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.BookTypeId);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(maxLength: 128),
                        Numbers = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        SecureCode = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(maxLength: 128),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "BookId", "dbo.Books");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CreditCards", "CustomerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Book_BookType_Mapping", "BookTypeId", "dbo.BookTypes");
            DropForeignKey("dbo.Book_BookType_Mapping", "BookId", "dbo.Books");
            DropForeignKey("dbo.Book_Author_Mapping", "BookTypeId", "dbo.BookTypes");
            DropForeignKey("dbo.Book_Author_Mapping", "BookId", "dbo.Books");
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.OrderItems", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.CreditCards", new[] { "CustomerId" });
            DropIndex("dbo.Book_BookType_Mapping", new[] { "BookTypeId" });
            DropIndex("dbo.Book_BookType_Mapping", new[] { "BookId" });
            DropIndex("dbo.Book_Author_Mapping", new[] { "BookTypeId" });
            DropIndex("dbo.Book_Author_Mapping", new[] { "BookId" });
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropTable("dbo.Publishers");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.CreditCards");
            DropTable("dbo.Book_BookType_Mapping");
            DropTable("dbo.BookTypes");
            DropTable("dbo.Book_Author_Mapping");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
            DropTable("dbo.Addresses");
        }
    }
}
