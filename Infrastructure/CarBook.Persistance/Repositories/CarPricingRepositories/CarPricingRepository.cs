using CarBook.Application.Interfaces.CarInterFaces;
using CarBook.Application.Interfaces.CarPricingInterFaces;
using CarBook.Application.ViewModels;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarBook.Persistance.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x =>x.Pricing).Where(z=>z.PricingID==2).ToList();
            return values;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From (Select Model,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([2],[3],[5])) as PivotTable;";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        
                        {
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal>
{
                              reader["2"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["2"]),
                              reader["3"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["3"]),
                              reader["5"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["5"])
}
                        };
                        values.Add(carPricingViewModel);
                    }
                }
                _context.Database.CloseConnection();
                return values;
            }
        }
    }
}
