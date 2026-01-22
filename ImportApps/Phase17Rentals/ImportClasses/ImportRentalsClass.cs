using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Phase17Rentals.ImportClasses;
public static class ImportRentalsClass
{
    public static async Task ImportRentalsAsync()
    {
        var farms = FarmHelperClass.GetAllFarms();
        BasicList<RentalInstanceDocument> list = [];
        foreach (var farm in farms)
        {
            RentalInstanceDocument rental = new()
            {
                Farm = farm,
                Rentals = []
            };
            list.Add(rental);
        }
        RentalInstanceDatabase db = new();
        await db.ImportAsync(list);
    }
}
