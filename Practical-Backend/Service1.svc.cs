using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace prac07_serviceB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //connect to DB
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<Product> getProducts()
        {
            dynamic productList = new List<Product>();
            var products = from p in db.Products
                           select p;
            foreach (Product p in products)
            {
                productList.Add(p);
            }
            return productList;
        }
        public Product getProduct(int id)
        {
            var product = (from p in db.Products
                           where p.P_ID.Equals(id)
                           select p).FirstOrDefault();
            return product;
        }

        public User login(string email, string password)
        {
            var user = (from u in db.Users
                        where u.Email.Equals(email) &&
                        u.Password.Equals(password)
                        select u).FirstOrDefault();
            return user;
        }

        public bool register(string email, string password, string user_type)
        {
            if (user_type == null)
            {
                user_type = "C";
            }
            var newUserObj = new User
            {
                Email = email,
                Password = password,
                User_type = user_type
            };
            db.Users.InsertOnSubmit(newUserObj);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }
        public bool addProduct(string name, string description, string category, double price, string status, string img)
        {

            var newProduct = new Product()
            {
                P_Name = name,
                P_Description = description,
                P_Category = category,
                P_Price = price,
                P_Image = img,
                P_Status = status
            };
            db.Products.InsertOnSubmit(newProduct);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
            return true;
        }

        public bool orderProduct(int user_id, int product_id, int quantity)
        {
            var newOrder = new Order()
            {
                U_ID = user_id,
                P_ID = product_id,
                QTY = quantity
            };
            db.Orders.InsertOnSubmit(newOrder);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
            return true;
        }
    }
}
