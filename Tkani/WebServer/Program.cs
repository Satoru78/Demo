using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using Tkani.Context;
using Tkani.Model;
using WebServer.Model;

namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener server = new HttpListener();
            server.Prefixes.Add("http://localhost:12345/");

            JsonSerializerOptions options = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            server.Start();

            while(true)
            {
                HttpListenerContext context = server.GetContext();
                if(context.Request.HttpMethod == "GET")
                {
                    try
                    {
                        if (context.Request.RawUrl == "/api/products/")
                        {
                            var listProduct = Data.tm.Product.ToList();
                            string response = JsonSerializer.Serialize(Data.tm.Product.ToList().ConvertAll(c => new ProductResponse(c)), options);
                            byte[] data = Encoding.UTF8.GetBytes(response);
                            context.Response.ContentType = "application/json;charset:utf-8";
                            using(Stream stream = context.Response.OutputStream)
                            {
                                context.Response.StatusCode = 200;
                                stream.Write(data, 0, data.Length);
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
                else if(context.Request.HttpMethod == "POST")
                {
                    try
                    {
                        if (context.Request.RawUrl == "/api/products/")
                        {
                            if(context.Request.ContentType == "application/json")
                            {
                                string request = "";
                                byte[] data = new byte[context.Request.ContentLength64];
                                using(Stream stream = context.Request.InputStream)
                                {
                                    stream.Read(data, 0, data.Length);
                                }
                                request = UTF8Encoding.UTF8.GetString(data);
                                var listProduct = JsonSerializer.Deserialize<List<ProductResponse>>(request);
                                foreach(var product in listProduct)
                                {
                                    Product products = new Product();                              
                                    products.Articul = product.Articul;
                                    products.Title = product.Title;
                                    products.Unit = product.Unit;
                                    products.Count = product.Count;
                                    products.Discount = product.Discount;
                                    products.Manufacturer = product.Manufacturer;
                                    products.Supplier = product.Supplier;
                                    products.IDProductCategory = product.IDProductCategory;
                                    products.QuantitiInStock = product.QuantitiInStock;
                                    products.Description = product.Description;
                                    products.Image = product.Image;
                                    Data.tm.Product.Add(products);
                                    Data.tm.SaveChanges();
                                }
                                Data.tm.SaveChanges();
                                context.Response.StatusCode = 200;
                                context.Response.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message );
                        context.Response.StatusCode = 400;
                        context.Response.Close();

                    }
                }
            }
        }
    }
}
