using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class LieuService : ILieuService
    {
         public ILieuRepository _rlieuRpository {  get; set; }
        private IMapper _mapper { get; set; }

        public LieuService(ILieuRepository rlieuRpository, IMapper mapper)
        {
            _mapper = mapper;
            _rlieuRpository = rlieuRpository;
        }

        public void AddLieu(LieuDto lieuDto)
        {
            var lieu = _mapper.Map<Lieu>(lieuDto);
            _rlieuRpository.AddLieu(lieu);
        }
    }
}
