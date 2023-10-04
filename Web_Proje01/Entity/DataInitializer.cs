using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Proje01.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {

                    new Category () {Name="KAMERA",Description="KAMERA ÜRÜNLERİ"},
                    new Category () {Name="TELEFON",Description="TELEFON ÜRÜNLERİ"},
                    new Category() {Name="BİLGİSAYAR",Description="BİLGİSAYAR ÜRÜNLERİ"}

            };
            foreach (var kategori in kategoriler) {  
                context.Categoris.Add(kategori);
            }

            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Canon",Description="kamera ürünleri",Price=25000,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,image="1.jpg"},
                new Product(){Name="Asus",Description="bilgisayar ürünleri",Price=20000,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,image="2.jpg"},
                new Product(){Name="Lenova",Description="bilgisayar ürünleri",Price=30000,Stock=110,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,image="3.jpg"},
                new Product(){Name="Samsung",Description="telefon ürünleri",Price=33000,Stock=120,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,image="4.jpg"},
                new Product() { Name="Apple", Description="telefon ürünleri", Price=40000, Stock=150, IsHome=true, IsApproved=true, IsFeatured=true, Slider=true, CategoryId=2, image="5.jpg" },
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}