using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using PROJET_C__GESTIONRESTO.Models;

namespace PROJET_C__GESTIONRESTO.Orm;

public partial class AppDbContext : DbContext
{
    private string connectionString;
    public AppDbContext(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attribution> Attributions { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Cartitem> Cartitems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Cover> Covers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Justification> Justifications { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Menuitem> Menuitems { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Orderitem> Orderitems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Attribution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("attribution");

            entity.HasIndex(e => e.Client, "fk_Reservation_Client1_idx");

            entity.HasIndex(e => e.Table, "fk_Reservation_Table1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Client).HasColumnType("int(11)");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.FinishAt)
                .HasColumnType("datetime")
                .HasColumnName("finishAt");
            entity.Property(e => e.StartAt)
                .HasColumnType("datetime")
                .HasColumnName("startAt");
            entity.Property(e => e.State)
                .HasMaxLength(45)
                .HasColumnName("state");
            entity.Property(e => e.Table).HasColumnType("int(11)");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.Attributions)
                .HasForeignKey(d => d.Client)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Reservation_Client1");

            entity.HasOne(d => d.TableNavigation).WithMany(p => p.Attributions)
                .HasForeignKey(d => d.Table)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Reservation_Table1");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cart");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Cartitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cartitem");

            entity.HasIndex(e => e.Cart, "fk_CartItem_Cart1_idx");

            entity.HasIndex(e => e.Inventory, "fk_CartItem_Inventory1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cart).HasColumnType("int(11)");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Inventory).HasColumnType("int(11)");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(11)")
                .HasColumnName("quantity");
            entity.Property(e => e.Unity)
                .HasMaxLength(45)
                .HasColumnName("unity");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.CartNavigation).WithMany(p => p.Cartitems)
                .HasForeignKey(d => d.Cart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_CartItem_Cart1");

            entity.HasOne(d => d.InventoryNavigation).WithMany(p => p.Cartitems)
                .HasForeignKey(d => d.Inventory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_CartItem_Inventory1");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("category");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Intitule)
                .HasMaxLength(45)
                .HasColumnName("intitule");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client");

            entity.HasIndex(e => e.Employee, "fk_Client_Operateur1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Tel, "tel_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Employee)
                .HasColumnType("int(11)")
                .HasColumnName("employee");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Prenom)
                .HasMaxLength(150)
                .HasColumnName("prenom");
            entity.Property(e => e.Tel)
                .HasMaxLength(45)
                .HasColumnName("tel");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.EmployeeNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.Employee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Client_Operateur1");
        });

        modelBuilder.Entity<Cover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cover");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Designation)
                .HasMaxLength(45)
                .HasColumnName("designation");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateadAt)
                .HasColumnType("datetime")
                .HasColumnName("createadAt");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasColumnType("json")
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("inventory");

            entity.HasIndex(e => e.Category, "fk_Provision_Categorie1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Category).HasColumnType("int(11)");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("designation");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(11)")
                .HasColumnName("quantity");
            entity.Property(e => e.Type)
                .HasMaxLength(45)
                .HasColumnName("type");
            entity.Property(e => e.Unity)
                .HasMaxLength(45)
                .HasColumnName("unity");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("fk_Provision_Categorie1");
        });

        modelBuilder.Entity<Justification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("justification");

            entity.HasIndex(e => e.CartItem, "fk_Justification_CartItem1_idx");

            entity.HasIndex(e => e.Product, "fk_Justification_Product1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CartItem).HasColumnType("int(11)");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Product).HasColumnType("int(11)");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.CartItemNavigation).WithMany(p => p.Justifications)
                .HasForeignKey(d => d.CartItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Justification_CartItem1");

            entity.HasOne(d => d.ProductNavigation).WithMany(p => p.Justifications)
                .HasForeignKey(d => d.Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Justification_Product1");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("menu");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Theme)
                .HasMaxLength(45)
                .HasColumnName("theme");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
        });

        modelBuilder.Entity<Menuitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("menuitem");

            entity.HasIndex(e => e.Menu, "fk_MenuItem_Menu1_idx");

            entity.HasIndex(e => e.Product, "fk_MenuItem_Product1_idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("createAt");
            entity.Property(e => e.Menu).HasColumnType("int(11)");
            entity.Property(e => e.Product).HasColumnType("int(11)");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.MenuNavigation).WithMany(p => p.Menuitems)
                .HasForeignKey(d => d.Menu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MenuItem_Menu1");

            entity.HasOne(d => d.ProductNavigation).WithMany(p => p.Menuitems)
                .HasForeignKey(d => d.Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MenuItem_Product1");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("order");

            entity.HasIndex(e => e.Client, "fk_Commande_Client1_idx");

            entity.HasIndex(e => e.Zone, "fk_Commande_Zone1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Client)
                .HasColumnType("int(11)")
                .HasColumnName("client");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.NumCom)
                .HasMaxLength(45)
                .HasColumnName("numCom");
            entity.Property(e => e.Status).HasMaxLength(45);
            entity.Property(e => e.Type)
                .HasMaxLength(45)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.Zone)
                .HasColumnType("int(11)")
                .HasColumnName("zone");

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Client)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Commande_Client1");

            entity.HasOne(d => d.ZoneNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Zone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Commande_Zone1");
        });

        modelBuilder.Entity<Orderitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("orderitem");

            entity.HasIndex(e => e.Order, "fk_ItemCommande_Commande1_idx");

            entity.HasIndex(e => e.Product, "fk_ItemCommande_Product1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Order).HasColumnType("int(11)");
            entity.Property(e => e.Product).HasColumnType("int(11)");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.OrderNavigation).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Order)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ItemCommande_Commande1");

            entity.HasOne(d => d.ProductNavigation).WithMany(p => p.Orderitems)
                .HasForeignKey(d => d.Product)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ItemCommande_Product1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.Category, "fk_Product_Categorie1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Category).HasColumnType("int(11)");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Designation)
                .HasMaxLength(45)
                .HasColumnName("designation");
            entity.Property(e => e.Image)
                .HasColumnType("text")
                .HasColumnName("image");
            entity.Property(e => e.UnityPrice).HasColumnName("unity_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("fk_Product_Categorie1");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("table");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Capacity)
                .HasColumnType("int(11)")
                .HasColumnName("capacity");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Position)
                .HasMaxLength(45)
                .HasColumnName("position");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("updateAt");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zone");

            entity.HasIndex(e => e.Cover, "fk_Zone_cover1_idx");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cover)
                .HasColumnType("int(11)")
                .HasColumnName("cover");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Designation)
                .HasMaxLength(45)
                .HasColumnName("designation");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");

            entity.HasOne(d => d.CoverNavigation).WithMany(p => p.Zones)
                .HasForeignKey(d => d.Cover)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Zone_cover1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
