using Azure;
using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Infrastructure.Repositories
{
    public class SortieRepository : ISortieRepository
    {
        public readonly SortieContext _context;

        // Une injection de dépendances
        public SortieRepository(SortieContext context)
        {
            _context = context;
        }

        // Pour ajouter une tâche
        public int AddSortie(Sortie sortie)
        {
            try
            {
                var idSortie = _context.Sortie.Add(sortie);
                _context.SaveChanges();
                return idSortie.Entity.Id;
            }
            catch (Exception e) 
            {
                return -1;
                throw;
            }
        }

        // Pour récuprer une tâche grâce à son Id
        public Sortie? GetSortie(int id)
        {
            try
            {
                return _context.Sortie.FirstOrDefault(s => s.isActive && s.Id == id);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        // Pour mettre à jour une tâche

        public void UpdateSortie(Sortie sortie)
        {
            try
            {
                var updateSortie = _context.Sortie.Update(sortie);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // Supprimer une sortie
        public void DeleteSortie(Sortie sortie)
        {
            try
            {
                sortie.isActive = false;
                _context.Sortie.Update(sortie);
                //  _context.Sortie.Remove(sortie);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
