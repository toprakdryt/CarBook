using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarInterFaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrand();
    }
}
