﻿using Application.Dto;


namespace Application.Services
{
    public interface IInscriptionService
    {
        void AddInscription(InscriptionDto inscription);
        InscriptionSortie GetInscriptionService(int id);

    }
}