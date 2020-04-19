namespace DAL
{
	public static class DbContent
	{
        public class ColumnDetails
        {
            public string Name;
            public string FullName;
        }
		public static class Tables
		{
			/// <summary>
			/// </summary>
			public static class Cities
			{
			public static string TableName  = "cities";
			public static string SelectAllTable  = "Select * from cities";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "cities_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails CityName = new ColumnDetails()
				{
					 Name="CityName",
					 FullName= "cities_CityName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Country = new ColumnDetails()
				{
					 Name="Country",
					 FullName= "cities_Country"
				};
				public static string allColumnsAlias = "cities.Id as cities_Id, cities.CityName as cities_CityName, cities.Country as cities_Country";
				public static string UpdateTable = "Update cities set CityName = @CityName, Country = @Country where Id = @Id";
				public static string Delete = "Delete from cities where Id = @Id";
				public static string Select = "Select * from cities where Id = @Id";
				public static string InsertTable = "Insert into cities(CityName, Country)Values(@CityName, @Country)";
			}
			/// <summary>
			/// </summary>
			public static class Users
			{
			public static string TableName  = "users";
			public static string SelectAllTable  = "Select * from users";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "users_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails UserName = new ColumnDetails()
				{
					 Name="UserName",
					 FullName= "users_UserName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Email = new ColumnDetails()
				{
					 Name="Email",
					 FullName= "users_Email"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails FirstName = new ColumnDetails()
				{
					 Name="FirstName",
					 FullName= "users_FirstName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails LastName = new ColumnDetails()
				{
					 Name="LastName",
					 FullName= "users_LastName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Phone = new ColumnDetails()
				{
					 Name="Phone",
					 FullName= "users_Phone"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Tell = new ColumnDetails()
				{
					 Name="Tell",
					 FullName= "users_Tell"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Password = new ColumnDetails()
				{
					 Name="Password",
					 FullName= "users_Password"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Street = new ColumnDetails()
				{
					 Name="Street",
					 FullName= "users_Street"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails HouseNumber = new ColumnDetails()
				{
					 Name="HouseNumber",
					 FullName= "users_HouseNumber"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Flat = new ColumnDetails()
				{
					 Name="Flat",
					 FullName= "users_Flat"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Code = new ColumnDetails()
				{
					 Name="Code",
					 FullName= "users_Code"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Fax = new ColumnDetails()
				{
					 Name="Fax",
					 FullName= "users_Fax"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails CityId = new ColumnDetails()
				{
					 Name="CityId",
					 FullName= "users_CityId"
				};
				public static string allColumnsAlias = "users.Id as users_Id, users.UserName as users_UserName, users.Email as users_Email, users.FirstName as users_FirstName, users.LastName as users_LastName, users.Phone as users_Phone, users.Tell as users_Tell, users.Password as users_Password, users.Street as users_Street, users.HouseNumber as users_HouseNumber, users.Flat as users_Flat, users.Code as users_Code, users.Fax as users_Fax, users.CityId as users_CityId";
				public static string UpdateTable = "Update users set UserName = @UserName, Email = @Email, FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Tell = @Tell, Password = @Password, Street = @Street, HouseNumber = @HouseNumber, Flat = @Flat, Code = @Code, Fax = @Fax, CityId = @CityId where Id = @Id";
				public static string Delete = "Delete from users where Id = @Id";
				public static string Select = "Select * from users where Id = @Id";
				public static string InsertTable = "Insert into users(UserName, Email, FirstName, LastName, Phone, Tell, Password, Street, HouseNumber, Flat, Code, Fax, CityId)Values(@UserName, @Email, @FirstName, @LastName, @Phone, @Tell, @Password, @Street, @HouseNumber, @Flat, @Code, @Fax, @CityId)";
			}
			/// <summary>
			/// </summary>
			public static class Sites
			{
			public static string TableName  = "sites";
			public static string SelectAllTable  = "Select * from sites";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "sites_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "sites_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "sites_Description"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Website = new ColumnDetails()
				{
					 Name="Website",
					 FullName= "sites_Website"
				};
				public static string allColumnsAlias = "sites.Id as sites_Id, sites.Name as sites_Name, sites.Description as sites_Description, sites.Website as sites_Website";
				public static string UpdateTable = "Update sites set Name = @Name, Description = @Description, Website = @Website where Id = @Id";
				public static string Delete = "Delete from sites where Id = @Id";
				public static string Select = "Select * from sites where Id = @Id";
				public static string InsertTable = "Insert into sites(Name, Description, Website)Values(@Name, @Description, @Website)";
			}
			/// <summary>
			/// </summary>
			public static class CustomersSites
			{
			public static string TableName  = "customers_sites";
			public static string SelectAllTable  = "Select * from customers_sites";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "customers_sites_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails CustomerId = new ColumnDetails()
				{
					 Name="CustomerId",
					 FullName= "customers_sites_CustomerId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails SiteId = new ColumnDetails()
				{
					 Name="SiteId",
					 FullName= "customers_sites_SiteId"
				};
				public static string allColumnsAlias = "customers_sites.Id as customers_sites_Id, customers_sites.CustomerId as customers_sites_CustomerId, customers_sites.SiteId as customers_sites_SiteId";
				public static string UpdateTable = "Update customers_sites set CustomerId = @CustomerId, SiteId = @SiteId where Id = @Id";
				public static string Delete = "Delete from customers_sites where Id = @Id";
				public static string Select = "Select * from customers_sites where Id = @Id";
				public static string InsertTable = "Insert into customers_sites(CustomerId, SiteId)Values(@CustomerId, @SiteId)";
			}
			/// <summary>
			/// </summary>
			public static class Colors
			{
			public static string TableName  = "colors";
			public static string SelectAllTable  = "Select * from colors";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "colors_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails ColorName = new ColumnDetails()
				{
					 Name="ColorName",
					 FullName= "colors_ColorName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails RgbColor = new ColumnDetails()
				{
					 Name="RgbColor",
					 FullName= "colors_RgbColor"
				};
				public static string allColumnsAlias = "colors.Id as colors_Id, colors.ColorName as colors_ColorName, colors.RgbColor as colors_RgbColor";
				public static string UpdateTable = "Update colors set ColorName = @ColorName, RgbColor = @RgbColor where Id = @Id";
				public static string Delete = "Delete from colors where Id = @Id";
				public static string Select = "Select * from colors where Id = @Id";
				public static string InsertTable = "Insert into colors(ColorName, RgbColor)Values(@ColorName, @RgbColor)";
			}
			/// <summary>
			/// </summary>
			public static class Vat
			{
			public static string TableName  = "vat";
			public static string SelectAllTable  = "Select * from vat";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "vat_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "vat_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "vat_Description"
				};
				public static string allColumnsAlias = "vat.Id as vat_Id, vat.Name as vat_Name, vat.Description as vat_Description";
				public static string UpdateTable = "Update vat set Name = @Name, Description = @Description where Id = @Id";
				public static string Delete = "Delete from vat where Id = @Id";
				public static string Select = "Select * from vat where Id = @Id";
				public static string InsertTable = "Insert into vat(Name, Description)Values(@Name, @Description)";
			}
			/// <summary>
			/// </summary>
			public static class Brands
			{
			public static string TableName  = "brands";
			public static string SelectAllTable  = "Select * from brands";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "brands_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "brands_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "brands_Description"
				};
				public static string allColumnsAlias = "brands.Id as brands_Id, brands.Name as brands_Name, brands.Description as brands_Description";
				public static string UpdateTable = "Update brands set Name = @Name, Description = @Description where Id = @Id";
				public static string Delete = "Delete from brands where Id = @Id";
				public static string Select = "Select * from brands where Id = @Id";
				public static string InsertTable = "Insert into brands(Name, Description)Values(@Name, @Description)";
			}
			/// <summary>
			/// </summary>
			public static class Materials
			{
			public static string TableName  = "materials";
			public static string SelectAllTable  = "Select * from materials";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "materials_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "materials_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails LoaziName = new ColumnDetails()
				{
					 Name="LoaziName",
					 FullName= "materials_LoaziName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "materials_Description"
				};
				public static string allColumnsAlias = "materials.Id as materials_Id, materials.Name as materials_Name, materials.LoaziName as materials_LoaziName, materials.Description as materials_Description";
				public static string UpdateTable = "Update materials set Name = @Name, LoaziName = @LoaziName, Description = @Description where Id = @Id";
				public static string Delete = "Delete from materials where Id = @Id";
				public static string Select = "Select * from materials where Id = @Id";
				public static string InsertTable = "Insert into materials(Name, LoaziName, Description)Values(@Name, @LoaziName, @Description)";
			}
			/// <summary>
			/// </summary>
			public static class Manufacturers
			{
			public static string TableName  = "manufacturers";
			public static string SelectAllTable  = "Select * from manufacturers";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "manufacturers_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "manufacturers_Name"
				};
				public static string allColumnsAlias = "manufacturers.Id as manufacturers_Id, manufacturers.Name as manufacturers_Name";
				public static string UpdateTable = "Update manufacturers set Name = @Name where Id = @Id";
				public static string Delete = "Delete from manufacturers where Id = @Id";
				public static string Select = "Select * from manufacturers where Id = @Id";
				public static string InsertTable = "Insert into manufacturers(Name)Values(@Name)";
			}
			/// <summary>
			/// </summary>
			public static class Sizes
			{
			public static string TableName  = "sizes";
			public static string SelectAllTable  = "Select * from sizes";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "sizes_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Size = new ColumnDetails()
				{
					 Name="Size",
					 FullName= "sizes_Size"
				};
				public static string allColumnsAlias = "sizes.Id as sizes_Id, sizes.Size as sizes_Size";
				public static string UpdateTable = "Update sizes set Size = @Size where Id = @Id";
				public static string Delete = "Delete from sizes where Id = @Id";
				public static string Select = "Select * from sizes where Id = @Id";
				public static string InsertTable = "Insert into sizes(Size)Values(@Size)";
			}
			/// <summary>
			/// </summary>
			public static class Categories
			{
			public static string TableName  = "categories";
			public static string SelectAllTable  = "Select * from categories";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "categories_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "categories_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "categories_Description"
				};
				public static string allColumnsAlias = "categories.Id as categories_Id, categories.Name as categories_Name, categories.Description as categories_Description";
				public static string UpdateTable = "Update categories set Name = @Name, Description = @Description where Id = @Id";
				public static string Delete = "Delete from categories where Id = @Id";
				public static string Select = "Select * from categories where Id = @Id";
				public static string InsertTable = "Insert into categories(Name, Description)Values(@Name, @Description)";
			}
			/// <summary>
			/// </summary>
			public static class SubCategories
			{
			public static string TableName  = "sub_categories";
			public static string SelectAllTable  = "Select * from sub_categories";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "sub_categories_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "sub_categories_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "sub_categories_Description"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails CategoryId = new ColumnDetails()
				{
					 Name="CategoryId",
					 FullName= "sub_categories_CategoryId"
				};
				public static string allColumnsAlias = "sub_categories.Id as sub_categories_Id, sub_categories.Name as sub_categories_Name, sub_categories.Description as sub_categories_Description, sub_categories.CategoryId as sub_categories_CategoryId";
				public static string UpdateTable = "Update sub_categories set Name = @Name, Description = @Description, CategoryId = @CategoryId where Id = @Id";
				public static string Delete = "Delete from sub_categories where Id = @Id";
				public static string Select = "Select * from sub_categories where Id = @Id";
				public static string InsertTable = "Insert into sub_categories(Name, Description, CategoryId)Values(@Name, @Description, @CategoryId)";
			}
			/// <summary>
			/// </summary>
			public static class Items
			{
			public static string TableName  = "items";
			public static string SelectAllTable  = "Select * from items";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "items_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Barcode = new ColumnDetails()
				{
					 Name="Barcode",
					 FullName= "items_Barcode"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails CustomerId = new ColumnDetails()
				{
					 Name="CustomerId",
					 FullName= "items_CustomerId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails SiteId = new ColumnDetails()
				{
					 Name="SiteId",
					 FullName= "items_SiteId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails BrandId = new ColumnDetails()
				{
					 Name="BrandId",
					 FullName= "items_BrandId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ManufacturerId = new ColumnDetails()
				{
					 Name="ManufacturerId",
					 FullName= "items_ManufacturerId"
				};
				public static string allColumnsAlias = "items.Id as items_Id, items.Barcode as items_Barcode, items.CustomerId as items_CustomerId, items.SiteId as items_SiteId, items.BrandId as items_BrandId, items.ManufacturerId as items_ManufacturerId";
				public static string UpdateTable = "Update items set Barcode = @Barcode, CustomerId = @CustomerId, SiteId = @SiteId, BrandId = @BrandId, ManufacturerId = @ManufacturerId where Id = @Id";
				public static string Delete = "Delete from items where Id = @Id";
				public static string Select = "Select * from items where Id = @Id";
				public static string InsertTable = "Insert into items(Barcode, CustomerId, SiteId, BrandId, ManufacturerId)Values(@Barcode, @CustomerId, @SiteId, @BrandId, @ManufacturerId)";
			}
			/// <summary>
			/// </summary>
			public static class ItemsChild
			{
			public static string TableName  = "items_child";
			public static string SelectAllTable  = "Select * from items_child";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "items_child_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "items_child_Name"
				};
			/// <summary>
			///Type: return text
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "items_child_Description"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails Stars = new ColumnDetails()
				{
					 Name="Stars",
					 FullName= "items_child_Stars"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails VatId = new ColumnDetails()
				{
					 Name="VatId",
					 FullName= "items_child_VatId"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails Price = new ColumnDetails()
				{
					 Name="Price",
					 FullName= "items_child_Price"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails PresentLess = new ColumnDetails()
				{
					 Name="PresentLess",
					 FullName= "items_child_PresentLess"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ColorId = new ColumnDetails()
				{
					 Name="ColorId",
					 FullName= "items_child_ColorId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Count = new ColumnDetails()
				{
					 Name="Count",
					 FullName= "items_child_Count"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Barcode = new ColumnDetails()
				{
					 Name="Barcode",
					 FullName= "items_child_Barcode"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ParentItemId = new ColumnDetails()
				{
					 Name="ParentItemId",
					 FullName= "items_child_ParentItemId"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails ShippingPrice = new ColumnDetails()
				{
					 Name="ShippingPrice",
					 FullName= "items_child_ShippingPrice"
				};
			/// <summary>
			///Type: return tinyint
			/// </summary>
				public static ColumnDetails Status = new ColumnDetails()
				{
					 Name="Status",
					 FullName= "items_child_Status"
				};
			/// <summary>
			///Type: return text
			/// </summary>
				public static ColumnDetails ShippingDescription = new ColumnDetails()
				{
					 Name="ShippingDescription",
					 FullName= "items_child_ShippingDescription"
				};
			/// <summary>
			///Type: return text
			/// </summary>
				public static ColumnDetails ReturnDescription = new ColumnDetails()
				{
					 Name="ReturnDescription",
					 FullName= "items_child_ReturnDescription"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails TimeShipping = new ColumnDetails()
				{
					 Name="TimeShipping",
					 FullName= "items_child_TimeShipping"
				};
			/// <summary>
			///Type: return datetime
			/// </summary>
				public static ColumnDetails CreationDate = new ColumnDetails()
				{
					 Name="CreationDate",
					 FullName= "items_child_CreationDate"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails UnitsStock = new ColumnDetails()
				{
					 Name="UnitsStock",
					 FullName= "items_child_UnitsStock"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails SizeId = new ColumnDetails()
				{
					 Name="SizeId",
					 FullName= "items_child_SizeId"
				};
				public static string allColumnsAlias = "items_child.Id as items_child_Id, items_child.Name as items_child_Name, items_child.Description as items_child_Description, items_child.Stars as items_child_Stars, items_child.VatId as items_child_VatId, items_child.Price as items_child_Price, items_child.PresentLess as items_child_PresentLess, items_child.ColorId as items_child_ColorId, items_child.Count as items_child_Count, items_child.Barcode as items_child_Barcode, items_child.ParentItemId as items_child_ParentItemId, items_child.ShippingPrice as items_child_ShippingPrice, items_child.Status as items_child_Status, items_child.ShippingDescription as items_child_ShippingDescription, items_child.ReturnDescription as items_child_ReturnDescription, items_child.TimeShipping as items_child_TimeShipping, items_child.CreationDate as items_child_CreationDate, items_child.UnitsStock as items_child_UnitsStock, items_child.SizeId as items_child_SizeId";
				public static string UpdateTable = "Update items_child set Name = @Name, Description = @Description, Stars = @Stars, VatId = @VatId, Price = @Price, PresentLess = @PresentLess, ColorId = @ColorId, Count = @Count, Barcode = @Barcode, ParentItemId = @ParentItemId, ShippingPrice = @ShippingPrice, Status = @Status, ShippingDescription = @ShippingDescription, ReturnDescription = @ReturnDescription, TimeShipping = @TimeShipping, CreationDate = @CreationDate, UnitsStock = @UnitsStock, SizeId = @SizeId where Id = @Id";
				public static string Delete = "Delete from items_child where Id = @Id";
				public static string Select = "Select * from items_child where Id = @Id";
				public static string InsertTable = "Insert into items_child(Name, Description, Stars, VatId, Price, PresentLess, ColorId, Count, Barcode, ParentItemId, ShippingPrice, Status, ShippingDescription, ReturnDescription, TimeShipping, CreationDate, UnitsStock, SizeId)Values(@Name, @Description, @Stars, @VatId, @Price, @PresentLess, @ColorId, @Count, @Barcode, @ParentItemId, @ShippingPrice, @Status, @ShippingDescription, @ReturnDescription, @TimeShipping, @CreationDate, @UnitsStock, @SizeId)";
			}
			/// <summary>
			/// </summary>
			public static class ItemCategories
			{
			public static string TableName  = "item_categories";
			public static string SelectAllTable  = "Select * from item_categories";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "item_categories_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails SubCategoryId = new ColumnDetails()
				{
					 Name="SubCategoryId",
					 FullName= "item_categories_SubCategoryId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemId = new ColumnDetails()
				{
					 Name="ItemId",
					 FullName= "item_categories_ItemId"
				};
				public static string allColumnsAlias = "item_categories.Id as item_categories_Id, item_categories.SubCategoryId as item_categories_SubCategoryId, item_categories.ItemId as item_categories_ItemId";
				public static string UpdateTable = "Update item_categories set SubCategoryId = @SubCategoryId, ItemId = @ItemId where Id = @Id";
				public static string Delete = "Delete from item_categories where Id = @Id";
				public static string Select = "Select * from item_categories where Id = @Id";
				public static string InsertTable = "Insert into item_categories(SubCategoryId, ItemId)Values(@SubCategoryId, @ItemId)";
			}
			/// <summary>
			/// </summary>
			public static class Images
			{
			public static string TableName  = "images";
			public static string SelectAllTable  = "Select * from images";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "images_Id"
				};
			/// <summary>
			///Type: return text
			/// </summary>
				public static ColumnDetails ImageSrc = new ColumnDetails()
				{
					 Name="ImageSrc",
					 FullName= "images_ImageSrc"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails ImageUrl = new ColumnDetails()
				{
					 Name="ImageUrl",
					 FullName= "images_ImageUrl"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemChildId = new ColumnDetails()
				{
					 Name="ItemChildId",
					 FullName= "images_ItemChildId"
				};
				public static string allColumnsAlias = "images.Id as images_Id, images.ImageSrc as images_ImageSrc, images.ImageUrl as images_ImageUrl, images.ItemChildId as images_ItemChildId";
				public static string UpdateTable = "Update images set ImageSrc = @ImageSrc, ImageUrl = @ImageUrl, ItemChildId = @ItemChildId where Id = @Id";
				public static string Delete = "Delete from images where Id = @Id";
				public static string Select = "Select * from images where Id = @Id";
				public static string InsertTable = "Insert into images(ImageSrc, ImageUrl, ItemChildId)Values(@ImageSrc, @ImageUrl, @ItemChildId)";
			}
			/// <summary>
			/// </summary>
			public static class Shipping
			{
			public static string TableName  = "shipping";
			public static string SelectAllTable  = "Select * from shipping";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "shipping_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "shipping_Description"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Status = new ColumnDetails()
				{
					 Name="Status",
					 FullName= "shipping_Status"
				};
			/// <summary>
			///Type: return datetime
			/// </summary>
				public static ColumnDetails ShippingDate = new ColumnDetails()
				{
					 Name="ShippingDate",
					 FullName= "shipping_ShippingDate"
				};
			/// <summary>
			///Type: return datetime
			/// </summary>
				public static ColumnDetails CreationDate = new ColumnDetails()
				{
					 Name="CreationDate",
					 FullName= "shipping_CreationDate"
				};
				public static string allColumnsAlias = "shipping.Id as shipping_Id, shipping.Description as shipping_Description, shipping.Status as shipping_Status, shipping.ShippingDate as shipping_ShippingDate, shipping.CreationDate as shipping_CreationDate";
				public static string UpdateTable = "Update shipping set Description = @Description, Status = @Status, ShippingDate = @ShippingDate, CreationDate = @CreationDate where Id = @Id";
				public static string Delete = "Delete from shipping where Id = @Id";
				public static string Select = "Select * from shipping where Id = @Id";
				public static string InsertTable = "Insert into shipping(Description, Status, ShippingDate, CreationDate)Values(@Description, @Status, @ShippingDate, @CreationDate)";
			}
			/// <summary>
			/// </summary>
			public static class Orders
			{
			public static string TableName  = "orders";
			public static string SelectAllTable  = "Select * from orders";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "orders_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ShippingId = new ColumnDetails()
				{
					 Name="ShippingId",
					 FullName= "orders_ShippingId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails UserId = new ColumnDetails()
				{
					 Name="UserId",
					 FullName= "orders_UserId"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails TotalPrice = new ColumnDetails()
				{
					 Name="TotalPrice",
					 FullName= "orders_TotalPrice"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Status = new ColumnDetails()
				{
					 Name="Status",
					 FullName= "orders_Status"
				};
			/// <summary>
			///Type: return tinyint
			/// </summary>
				public static ColumnDetails Paid = new ColumnDetails()
				{
					 Name="Paid",
					 FullName= "orders_Paid"
				};
				public static string allColumnsAlias = "orders.Id as orders_Id, orders.ShippingId as orders_ShippingId, orders.UserId as orders_UserId, orders.TotalPrice as orders_TotalPrice, orders.Status as orders_Status, orders.Paid as orders_Paid";
				public static string UpdateTable = "Update orders set ShippingId = @ShippingId, UserId = @UserId, TotalPrice = @TotalPrice, Status = @Status, Paid = @Paid where Id = @Id";
				public static string Delete = "Delete from orders where Id = @Id";
				public static string Select = "Select * from orders where Id = @Id";
				public static string InsertTable = "Insert into orders(ShippingId, UserId, TotalPrice, Status, Paid)Values(@ShippingId, @UserId, @TotalPrice, @Status, @Paid)";
			}
			/// <summary>
			/// </summary>
			public static class OrderItems
			{
			public static string TableName  = "order_items";
			public static string SelectAllTable  = "Select * from order_items";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "order_items_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemChildId = new ColumnDetails()
				{
					 Name="ItemChildId",
					 FullName= "order_items_ItemChildId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Count = new ColumnDetails()
				{
					 Name="Count",
					 FullName= "order_items_Count"
				};
			/// <summary>
			///Type: return double
			/// </summary>
				public static ColumnDetails Price = new ColumnDetails()
				{
					 Name="Price",
					 FullName= "order_items_Price"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Status = new ColumnDetails()
				{
					 Name="Status",
					 FullName= "order_items_Status"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails OrderId = new ColumnDetails()
				{
					 Name="OrderId",
					 FullName= "order_items_OrderId"
				};
				public static string allColumnsAlias = "order_items.Id as order_items_Id, order_items.ItemChildId as order_items_ItemChildId, order_items.Count as order_items_Count, order_items.Price as order_items_Price, order_items.Status as order_items_Status, order_items.OrderId as order_items_OrderId";
				public static string UpdateTable = "Update order_items set ItemChildId = @ItemChildId, Count = @Count, Price = @Price, Status = @Status, OrderId = @OrderId where Id = @Id";
				public static string Delete = "Delete from order_items where Id = @Id";
				public static string Select = "Select * from order_items where Id = @Id";
				public static string InsertTable = "Insert into order_items(ItemChildId, Count, Price, Status, OrderId)Values(@ItemChildId, @Count, @Price, @Status, @OrderId)";
			}
			/// <summary>
			/// </summary>
			public static class Payments
			{
			public static string TableName  = "payments";
			public static string SelectAllTable  = "Select * from payments";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "payments_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails TransactionId = new ColumnDetails()
				{
					 Name="TransactionId",
					 FullName= "payments_TransactionId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails OrderId = new ColumnDetails()
				{
					 Name="OrderId",
					 FullName= "payments_OrderId"
				};
			/// <summary>
			///Type: return datetime
			/// </summary>
				public static ColumnDetails Date = new ColumnDetails()
				{
					 Name="Date",
					 FullName= "payments_Date"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Type = new ColumnDetails()
				{
					 Name="Type",
					 FullName= "payments_Type"
				};
				public static string allColumnsAlias = "payments.Id as payments_Id, payments.TransactionId as payments_TransactionId, payments.OrderId as payments_OrderId, payments.Date as payments_Date, payments.Type as payments_Type";
				public static string UpdateTable = "Update payments set TransactionId = @TransactionId, OrderId = @OrderId, Date = @Date, Type = @Type where Id = @Id";
				public static string Delete = "Delete from payments where Id = @Id";
				public static string Select = "Select * from payments where Id = @Id";
				public static string InsertTable = "Insert into payments(TransactionId, OrderId, Date, Type)Values(@TransactionId, @OrderId, @Date, @Type)";
			}
			/// <summary>
			/// </summary>
			public static class Baskets
			{
			public static string TableName  = "baskets";
			public static string SelectAllTable  = "Select * from baskets";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "baskets_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemChildId = new ColumnDetails()
				{
					 Name="ItemChildId",
					 FullName= "baskets_ItemChildId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Count = new ColumnDetails()
				{
					 Name="Count",
					 FullName= "baskets_Count"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails UserId = new ColumnDetails()
				{
					 Name="UserId",
					 FullName= "baskets_UserId"
				};
				public static string allColumnsAlias = "baskets.Id as baskets_Id, baskets.ItemChildId as baskets_ItemChildId, baskets.Count as baskets_Count, baskets.UserId as baskets_UserId";
				public static string UpdateTable = "Update baskets set ItemChildId = @ItemChildId, Count = @Count, UserId = @UserId where Id = @Id";
				public static string Delete = "Delete from baskets where Id = @Id";
				public static string Select = "Select * from baskets where Id = @Id";
				public static string InsertTable = "Insert into baskets(ItemChildId, Count, UserId)Values(@ItemChildId, @Count, @UserId)";
			}
			/// <summary>
			/// </summary>
			public static class WishList
			{
			public static string TableName  = "wish_list";
			public static string SelectAllTable  = "Select * from wish_list";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "wish_list_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemChildId = new ColumnDetails()
				{
					 Name="ItemChildId",
					 FullName= "wish_list_ItemChildId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails UserId = new ColumnDetails()
				{
					 Name="UserId",
					 FullName= "wish_list_UserId"
				};
				public static string allColumnsAlias = "wish_list.Id as wish_list_Id, wish_list.ItemChildId as wish_list_ItemChildId, wish_list.UserId as wish_list_UserId";
				public static string UpdateTable = "Update wish_list set ItemChildId = @ItemChildId, UserId = @UserId where Id = @Id";
				public static string Delete = "Delete from wish_list where Id = @Id";
				public static string Select = "Select * from wish_list where Id = @Id";
				public static string InsertTable = "Insert into wish_list(ItemChildId, UserId)Values(@ItemChildId, @UserId)";
			}
			/// <summary>
			/// </summary>
			public static class Features
			{
			public static string TableName  = "features";
			public static string SelectAllTable  = "Select * from features";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "features_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "features_Name"
				};
				public static string allColumnsAlias = "features.Id as features_Id, features.Name as features_Name";
				public static string UpdateTable = "Update features set Name = @Name where Id = @Id";
				public static string Delete = "Delete from features where Id = @Id";
				public static string Select = "Select * from features where Id = @Id";
				public static string InsertTable = "Insert into features(Name)Values(@Name)";
			}
			/// <summary>
			/// </summary>
			public static class ItemFeatures
			{
			public static string TableName  = "item_features";
			public static string SelectAllTable  = "Select * from item_features";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "item_features_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails ItemId = new ColumnDetails()
				{
					 Name="ItemId",
					 FullName= "item_features_ItemId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails FeatureId = new ColumnDetails()
				{
					 Name="FeatureId",
					 FullName= "item_features_FeatureId"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Value = new ColumnDetails()
				{
					 Name="Value",
					 FullName= "item_features_Value"
				};
				public static string allColumnsAlias = "item_features.Id as item_features_Id, item_features.ItemId as item_features_ItemId, item_features.FeatureId as item_features_FeatureId, item_features.Value as item_features_Value";
				public static string UpdateTable = "Update item_features set ItemId = @ItemId, FeatureId = @FeatureId, Value = @Value where Id = @Id";
				public static string Delete = "Delete from item_features where Id = @Id";
				public static string Select = "Select * from item_features where Id = @Id";
				public static string InsertTable = "Insert into item_features(ItemId, FeatureId, Value)Values(@ItemId, @FeatureId, @Value)";
			}
			/// <summary>
			/// </summary>
			public static class CategoryFeatures
			{
			public static string TableName  = "category_features";
			public static string SelectAllTable  = "Select * from category_features";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "category_features_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails FeatureId = new ColumnDetails()
				{
					 Name="FeatureId",
					 FullName= "category_features_FeatureId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails CategoryId = new ColumnDetails()
				{
					 Name="CategoryId",
					 FullName= "category_features_CategoryId"
				};
				public static string allColumnsAlias = "category_features.Id as category_features_Id, category_features.FeatureId as category_features_FeatureId, category_features.CategoryId as category_features_CategoryId";
				public static string UpdateTable = "Update category_features set Id = @Id, FeatureId = @FeatureId, CategoryId = @CategoryId where Id = @Id";
				public static string Delete = "Delete from category_features where Id = @Id";
				public static string Select = "Select * from category_features where Id = @Id";
				public static string InsertTable = "Insert into category_features(Id, FeatureId, CategoryId)Values(@Id, @FeatureId, @CategoryId)";
			}
			/// <summary>
			/// </summary>
			public static class Search
			{
			public static string TableName  = "search";
			public static string SelectAllTable  = "Select * from search";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "search_Id"
				};
			/// <summary>
			///Type: return datetime
			/// </summary>
				public static ColumnDetails DateSearch = new ColumnDetails()
				{
					 Name="DateSearch",
					 FullName= "search_DateSearch"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails UserId = new ColumnDetails()
				{
					 Name="UserId",
					 FullName= "search_UserId"
				};
				public static string allColumnsAlias = "search.Id as search_Id, search.DateSearch as search_DateSearch, search.UserId as search_UserId";
				public static string UpdateTable = "Update search set DateSearch = @DateSearch, UserId = @UserId where Id = @Id";
				public static string Delete = "Delete from search where Id = @Id";
				public static string Select = "Select * from search where Id = @Id";
				public static string InsertTable = "Insert into search(DateSearch, UserId)Values(@DateSearch, @UserId)";
			}
			/// <summary>
			/// </summary>
			public static class SearchFeatures
			{
			public static string TableName  = "search_features";
			public static string SelectAllTable  = "Select * from search_features";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "search_features_Id"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails FeatureId = new ColumnDetails()
				{
					 Name="FeatureId",
					 FullName= "search_features_FeatureId"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails SearchId = new ColumnDetails()
				{
					 Name="SearchId",
					 FullName= "search_features_SearchId"
				};
				public static string allColumnsAlias = "search_features.Id as search_features_Id, search_features.FeatureId as search_features_FeatureId, search_features.SearchId as search_features_SearchId";
				public static string UpdateTable = "Update search_features set FeatureId = @FeatureId, SearchId = @SearchId where Id = @Id";
				public static string Delete = "Delete from search_features where Id = @Id";
				public static string Select = "Select * from search_features where Id = @Id";
				public static string InsertTable = "Insert into search_features(FeatureId, SearchId)Values(@FeatureId, @SearchId)";
			}
			/// <summary>
			/// </summary>
			public static class Customers
			{
			public static string TableName  = "customers";
			public static string SelectAllTable  = "Select * from customers";
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Id = new ColumnDetails()
				{
					 Name="Id",
					 FullName= "customers_Id"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Name = new ColumnDetails()
				{
					 Name="Name",
					 FullName= "customers_Name"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Email = new ColumnDetails()
				{
					 Name="Email",
					 FullName= "customers_Email"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Phone = new ColumnDetails()
				{
					 Name="Phone",
					 FullName= "customers_Phone"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Fax = new ColumnDetails()
				{
					 Name="Fax",
					 FullName= "customers_Fax"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Image = new ColumnDetails()
				{
					 Name="Image",
					 FullName= "customers_Image"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Description = new ColumnDetails()
				{
					 Name="Description",
					 FullName= "customers_Description"
				};
			/// <summary>
			///Type: return tinyint
			/// </summary>
				public static ColumnDetails Status = new ColumnDetails()
				{
					 Name="Status",
					 FullName= "customers_Status"
				};
			/// <summary>
			///Type: return int
			/// </summary>
				public static ColumnDetails Stars = new ColumnDetails()
				{
					 Name="Stars",
					 FullName= "customers_Stars"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails CreationDate = new ColumnDetails()
				{
					 Name="CreationDate",
					 FullName= "customers_CreationDate"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails UserName = new ColumnDetails()
				{
					 Name="UserName",
					 FullName= "customers_UserName"
				};
			/// <summary>
			///Type: return varchar
			/// </summary>
				public static ColumnDetails Password = new ColumnDetails()
				{
					 Name="Password",
					 FullName= "customers_Password"
				};
				public static string allColumnsAlias = "customers.Id as customers_Id, customers.Name as customers_Name, customers.Email as customers_Email, customers.Phone as customers_Phone, customers.Fax as customers_Fax, customers.Image as customers_Image, customers.Description as customers_Description, customers.Status as customers_Status, customers.Stars as customers_Stars, customers.CreationDate as customers_CreationDate, customers.UserName as customers_UserName, customers.Password as customers_Password";
				public static string UpdateTable = "Update customers set Name = @Name, Email = @Email, Phone = @Phone, Fax = @Fax, Image = @Image, Description = @Description, Status = @Status, Stars = @Stars, CreationDate = @CreationDate, UserName = @UserName, Password = @Password where Id = @Id";
				public static string Delete = "Delete from customers where Id = @Id";
				public static string Select = "Select * from customers where Id = @Id";
				public static string InsertTable = "Insert into customers(Name, Email, Phone, Fax, Image, Description, Status, Stars, CreationDate, UserName, Password)Values(@Name, @Email, @Phone, @Fax, @Image, @Description, @Status, @Stars, @CreationDate, @UserName, @Password)";
			}
		}
		public static class StoredProcedures
		{
		}
		public static class Functions
		{
		}
		public static class Views
		{
		}
	}
}
