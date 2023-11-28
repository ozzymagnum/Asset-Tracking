using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new MyDbContext())
            {
                try
                {
                    
                    // Get and sort phones
                    List<Phone> sortedPhones = dbContext.Phones.OrderBy(p => p.Model).ThenBy(p => p.PurchaseDate).ToList();

                    // Display sorted phones
                    Console.WriteLine("Sorted Phones:");
                    foreach (var phone in sortedPhones)
                    {
                        Console.WriteLine($"{phone.Id}: {phone.Model}: {phone.PurchaseDate.Date.ToString("dd-MM-yyyy")}");
                    }
                    Console.WriteLine("\nSorting with colors\n");
                    // RED MARK
                    DateTime currentDateTime = DateTime.Now;
                    List<Phone> Result = dbContext.Phones.OrderBy(p => p.PurchaseDate).ToList();
                    foreach (Phone phone in Result)
                    {
                        DateTime threeYearsFromNow = currentDateTime.AddYears(3);
                        DateTime threeMonthsAgo = currentDateTime.AddMonths(-3);
                       
                        if (phone.PurchaseDate > threeMonthsAgo && phone.PurchaseDate < threeYearsFromNow)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        
                        Console.WriteLine($"{phone.Id}: {phone.Model}: {phone.PurchaseDate.Date.ToString("yyyy-MM-dd")}");
                    }

                    // Get and sort laptops after phones
                    List<Laptop> sortedLaptops = dbContext.Laptops.OrderBy(l => l.Model).ToList();

                    // Display sorted laptops
                    Console.WriteLine("\nSorted Laptops:");
                    foreach (var laptop in sortedLaptops)
                    {
                        Console.WriteLine($"{laptop.Id}: {laptop.Model}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    // Log the exception or handle it as needed
                }
            }
        }
    }
}


