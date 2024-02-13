using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class LieuService : ILieuService
    {
        public ILieuRepository _rlieuRpository { get; set; }
        private IMapper _mapper { get; }
        

        public LieuService(ILieuRepository rlieuRpository, IMapper mapper)
        {
            _rlieuRpository = rlieuRpository;
            _mapper = mapper;
            
        }

        public int AddLieu(LieuDto lieu)
        {

            Lieu nouveauLieu = _mapper.Map<LieuDto, Lieu>(lieu);

            

            try
            {
                _rlieuRpository.AddLieu(nouveauLieu);
                return nouveauLieu.Id;
            }
            catch (Exception ex)
            {

            }
            return -1;
        }

        public LieuSortie GetLieu(int id)
        {
            Lieu lieuDao = _rlieuRpository.GetLieuById(id);
            LieuSortie result = _mapper.Map<Lieu, LieuSortie>(lieuDao);



            return result;
        }
    }
}
