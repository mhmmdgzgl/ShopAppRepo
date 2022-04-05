using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    //bilgileri data katmanından alacak.
    public interface IProductService 
    {
        // Belli başlı metot imzaları hazırlanacak.

        Product GetById(int id); // id ile bir product alacak dışarıdan
        List<Product> GetAll(); // bütün product'ları getirecek metot

        List<Product> GetPopularProducts();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

    }
}
