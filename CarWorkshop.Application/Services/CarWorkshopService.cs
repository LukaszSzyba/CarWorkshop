using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Domain.Intefaces;

namespace CarWorkshop.Application.Services
{
    public class CarWorkshopService : ICarWorkshopService
    {
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        private readonly IMapper _mapper;
        public CarWorkshopService(ICarWorkshopRepository carWorkshopRepository, IMapper mapper)
        {
            _carWorkshopRepository = carWorkshopRepository;
            _mapper = mapper;
        }
        public async Task Create(CarWorkshopDto carWorkshopDto)
        {
            //BEZ uzycia automapera

            //var carWorkshopEntity = new Domain.Entities.CarWorkshop()
            //{
            //    Name = carWorkshopDto.Name,
            //    About = carWorkshopDto.About,
            //    Description = carWorkshopDto.Description,
            //    ContactDetails = new Domain.Entities.CarWorkshopContactDetails()
            //    {
            //        PhoneNumber = carWorkshopDto.PhoneNumber,
            //        Street = carWorkshopDto.Street,
            //        City = carWorkshopDto.City,
            //        PostalCode = carWorkshopDto.PostalCode,
            //    }
            //};

            //carWorkshopEntity.EncodeName();
            //await _carWorkshopRepository.Create(carWorkshopEntity);

            var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(carWorkshopDto);

            carWorkshop.EncodeName();
            await _carWorkshopRepository.Create(carWorkshop);
        }
    }
}
