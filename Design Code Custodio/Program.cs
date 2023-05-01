using System;

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Design_Code_Custodio
{
    internal class Program
    {

        public class User
        {
            public int id;
            public String name;
            private String email;
            private String password;
            private String address;
            private String phone;
            private String dni;
            private String role;
        }
        public void addComment()
        {
            return;
        }
        public void addReview()
        {
            return;
        }
        
        public class Category
        {
            private int id;
            private String name;
        }
        public class Subcategory
        {
            public int id;
            public String name;
            public Category category;
        }
        public class Subsubcategory
        {
            public int id;
            public String name;
            public Subcategory subcategory;
        }
        public class Product
        {
            public int id;
            public String name;
            public String description;
            public double baseprice;
            public int quantity;
            public Category category;
            public Subcategory subcategory;
            public Subsubcategory subsubcategory;
        }


        public class Order
        {
            private int id;
            private Date date;
            private User user;
            private String status;
            public double totalPrice;
            private List<OrderProduct> orderProducts;
        }
        public class OrderProduct
        {
            private int id;
            private Order order;
            public Product product;
            private int quantity;
            public float finalprice;
            public float discount;
        }




        ¡

    }
}
