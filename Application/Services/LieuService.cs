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

        public int AddLieu(LieuDto lieuDto)
        {

            try
            {
                // On fait le mappping 
                var lieu = _mapper.Map<Lieu>(lieuDto);
                return _rlieuRpository.AddLieu(lieu);
            }
            catch (Exception e)
            {
                return -1;
                throw;
            }
        }

        public LieuDto? GetLieu(int id)
        {
            var lieu = _rlieuRpository.GetLieu(id);
            if (lieu != null)
            {
                var dtoPourAvoiriDLieu = _mapper.Map<LieuDto>(lieu);
                return dtoPourAvoiriDLieu;
            }
            return null;
        }
    }
}
