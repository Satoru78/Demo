using SportMaster.Context;
using SportMaster.Model;
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
using WebApiServer.ApiModel;

namespace WebApiServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener server = new HttpListener();
            server.Prefixes.Add("http://localhost:60000/");

            JsonSerializerOptions options = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            server.Start();

            while(true)
            {
                HttpListenerContext context = server.GetContext();
                if (context.Request.HttpMethod == "GET")
                {
                    try
                    {
                        if(context.Request.RawUrl == "/api/products/")
                        {
                            var productList = Data.sm.Product.ToList();
                            string response = JsonSerializer.Serialize(Data.sm.Product.ToList().ConvertAll(c => new ProductResponse(c)), options);
                            byte[] data = Encoding.UTF8.GetBytes(response);
                            context.Response.ContentType = "application/json;charset=utf-8";
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
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
                else if (context.Request.HttpMethod == "DELETE")
                {
                    try
                    {
                        if (context.Request.QueryString.Count == 1)
                        {
                            if (context.Request.QueryString.Keys[0] == "id")
                            {
                                int id = Convert.ToInt32(context.Request.QueryString.Get(0));
                                var currentProduct = Data.sm.Product.FirstOrDefault(b => b.ID == id);
                                if (currentProduct != null)
                                {
                                    Data.sm.Product.Remove(currentProduct);
                                    Data.sm.SaveChanges();
                                    context.Response.StatusCode = 200;
                                    context.Response.Close();
                                }
                            }
                        }
                    }
                    catch
                    {
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
                else if (context.Request.HttpMethod == "POST")
                {
                    try
                    {
                        if (context.Request.RawUrl == "/api/products/")
                        {
                            if (context.Request.ContentType == "application/json")
                            {
                                string request = "";
                                byte[] data = new byte[context.Request.ContentLength64];
                                using (Stream stream = context.Request.InputStream)
                                {
                                    stream.Read(data, 0, data.Length);
                                }
                                request = UTF8Encoding.UTF8.GetString(data);
                                var productList = JsonSerializer.Deserialize<List<ProductResponse>>(request);
                                foreach (var item in productList)
                                {
                                    Product objects = new Product();
                                   
                                    objects.Articul = item.Articul;
                                    objects.Title = item.Title;
                                    objects.Unit = item.Unit;
                                    objects.Count = item.Count;
                                    objects.Discount = item.Discount;
                                    objects.Manufacturer = item.Manufacturer;
                                    objects.Supplier = item.Supplier;
                                    objects.IDProductCategory = item.IDProductCategory;
                                    objects.QuantitiInStock = item.QuantitiInStock;
                                    objects.Description = item.Description;
                                    objects.Image = item.Image;
                                    Data.sm.Product.Add(objects);
                                }
                                Data.sm.SaveChanges();
                                context.Response.StatusCode = 200;
                                context.Response.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        context.Response.StatusCode = 400;
                        context.Response.Close();

                    }
                }

            }
        }
    }
}
